using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using YooAsset;
using HybridCLR;
using System.Linq;

/// <summary>
/// 启动场景（HotUpdate.unity）的热更新总控脚本。
/// 本脚本只负责流程编排；UI 的表现逻辑（进度条/文本/状态、提示面板与按钮）分别收敛在
/// HotUpdatePanel 与 HotUpdateTipPanel 两个界面脚本中。
///
/// 需求流程（与界面一一对应）：
///   1) 校验阶段：进度条 0%、进度文本 0%、状态文本"校验中"
///   2) 没有更新内容：进度条 100%、进度文本 100%、状态文本"加载中"
///   3) 有更新内容：弹出 HotUpdateTipPanel，提示"存在新版本，下载需xx.xMB。是否立即下载？"
///      确认 -> 开始下载；退出 -> 退出游戏
///   4) 下载阶段：进度条/进度文本跟随下载进度，状态文本"下载中"
///   5) 下载完成：进度条 100%、进度文本 100%、状态文本"加载中"
///   6) 无论是否更新：加载程序集完毕后延迟 1.5s 再执行热更入口，期间保持"加载中"
///
/// 技术选型（均已按本工程实际安装版本核对 API）：
///   - YooAsset 3.0.5 原生 API，初始化/打补丁流程参考官方 Space Shooter 示例；
///   - HybridCLR 8.13.0 RuntimeApi.LoadMetadataForAOTAssembly + Assembly.Load，
///     热更入口按 HotUpdateEntry.Entry 反射调用（与官方示例一致）。
/// </summary>
public class Load : MonoBehaviour
{
    /// <summary>
    /// 资源系统运行模式（对应 YooAsset.EPlayMode，HostPlayMode=3）。
    /// </summary>
    public EPlayMode playMode = EPlayMode.HostPlayMode;

    /// <summary>资源包名称</summary>
    public string packageName = "DefaultPackage";

    /// <summary>主资源服务器地址</summary>
    public string defaultHostServer = string.Empty;

    /// <summary>备用资源服务器地址</summary>
    public string fallbackHostServer = string.Empty;

    /// <summary>下载最大并发数</summary>
    public int downloadMaxConcurrency = 4;

    /// <summary>下载失败重试次数</summary>
    public int downloadRetryCount = 3;

    /// <summary>请求清单超时时间（秒）</summary>
    public int manifestTimeout = 60;

    /// <summary>需要补充 AOT 元数据的程序集名（不含扩展名）</summary>
    public List<string> aotMetaAssemblies = new List<string>();

    /// <summary>热更程序集名称（不含扩展名）</summary>
    public string hotUpdateAssemblyName = "HotUpdate";

    /// <summary>热更入口类型全名</summary>
    public string hotUpdateEntryType = "HotUpdateEntry";

    /// <summary>热更入口静态方法名</summary>
    public string hotUpdateEntryMethod = "Entry";

    /// <summary>热更进度面板（进度条/进度文本/状态文本）</summary>
    public HotUpdatePanel updatePanel;

    /// <summary>热更提示面板（确认下载/退出游戏）</summary>
    public HotUpdateTipPanel updateTipPanel;

    /// <summary>DLL 原始文件在资源包内的地址前缀（Assets/HotUpdate/DLLs 打包后为 DLLs_*）</summary>
    private const string DllLocationPrefix = "DLLs_";

    private const string StateCheck = "校验中";
    private const string StateDownload = "下载中";
    private const string StateLoad = "加载中";

    private static bool _yooInitialized = false;

    private ResourcePackage _package;
    private bool _running = false;
    private bool _userSure = false;   // 用户点击"确认"
    private bool _userQuit = false;   // 用户点击"退出"
    private ResourceDownloaderOperation _downloader;

    private void Start()
    {
        StartCoroutine(HotUpdateFlow());
    }

    /// <summary>
    /// 热更新主流程。
    /// </summary>
    private IEnumerator HotUpdateFlow()
    {
        if (_running)
            yield break;
        _running = true;

        // ---- 界面初始状态（UI 表现由 HotUpdatePanel / HotUpdateTipPanel 负责）----
        if (updateTipPanel != null)
            updateTipPanel.Hide();
        if (updatePanel != null)
        {
            updatePanel.Show();
            updatePanel.SetProgress(0f);
            updatePanel.SetState(StateCheck);
        }

        // 初始化 YooAsset 资源系统
        try
        {
            if (!_yooInitialized)
            {
                YooAssets.Initialize();
                _yooInitialized = true;
            }
        }
        catch (Exception e)
        {
            SetUIState($"初始化失败：{e.Message}");
            Debug.LogError($"[Load] YooAssets.Initialize failed : {e}");
            _running = false;
            yield break;
        }

        // ---- 1. 校验阶段：创建并初始化资源包（此阶段进度保持 0%） ----
        yield return StartCoroutine(InitializePackage());
        if (_running == false)
            yield break;

        // 请求资源版本并加载清单（四种模式统一执行：联机模式请求的是远端版本，
        // 模拟/离线模式请求到的是本地清单版本）。加载完成后资源包才会具备 active manifest，
        // 之后才能创建下载器统计更新内容。
        var versionOperation = _package.RequestPackageVersionAsync();
        yield return versionOperation;
        if (versionOperation.Status != EOperationStatus.Succeeded)
        {
            SetUIState($"校验失败：{versionOperation.Error}");
            Debug.LogError($"[Load] Request package version failed : {versionOperation.Error}");
            _running = false;
            yield break;
        }
        Debug.Log($"[Load] Package version : {versionOperation.PackageVersion}");

        // 加载（更新）资源清单
        var loadOptions = new LoadPackageManifestOptions(versionOperation.PackageVersion, manifestTimeout);
        var manifestOperation = _package.LoadPackageManifestAsync(loadOptions);
        yield return manifestOperation;
        if (manifestOperation.Status != EOperationStatus.Succeeded)
        {
            SetUIState($"校验失败：{manifestOperation.Error}");
            Debug.LogError($"[Load] Load package manifest failed : {manifestOperation.Error}");
            _running = false;
            yield break;
        }

        // 创建下载器：统计需要更新的资源
        var downloaderOptions = new ResourceDownloaderOptions(downloadMaxConcurrency, downloadRetryCount);
        _downloader = _package.CreateResourceDownloader(downloaderOptions);

        if (_downloader.TotalDownloadCount == 0)
        {
            // ---- 2. 没有更新内容：100% + "加载中"，随后加载程序集并延迟 1.5s 进入 ----
            Debug.Log("[Load] No update files were found.");
            yield return StartCoroutine(EnterLoadStateAndRunHotUpdate());
        }
        else
        {
            // ---- 3. 有更新内容：弹出更新提示面板（文本与按钮绑定均在 HotUpdateTipPanel 内部完成），等待用户决策 ----
            long totalBytes = _downloader.TotalDownloadBytes;
            float sizeMB = Mathf.Clamp(totalBytes / 1048576f, 0.1f, float.MaxValue);
            Debug.Log($"[Load] Found update files. Count: {_downloader.TotalDownloadCount}, Size: {sizeMB:0.0}MB.");

            _userSure = false;
            _userQuit = false;
            if (updateTipPanel != null)
            {
                updateTipPanel.ShowMessage($"存在新版本，下载需{sizeMB:0.0}MB。是否立即下载？", OnSureButton, OnQuitButton);
            }
            else
            {
                // 面板缺失时按"确认下载"处理，避免流程卡死
                Debug.LogError("[Load] updateTipPanel is missing! Force start download.");
                _userSure = true;
            }

            // 等待用户点击
            while (_userSure == false && _userQuit == false)
                yield return null;

            if (_userQuit)
            {
                // 点击"退出"按钮：退出游戏
                QuitGame();
                yield break;
            }

            // ---- 4. 下载阶段：隐藏提示面板，进度跟随下载进度，状态"下载中" ----
            if (updateTipPanel != null)
                updateTipPanel.Hide();
            if (updatePanel != null)
            {
                updatePanel.SetState(StateDownload);
                updatePanel.SetProgress(0f);
            }

            _downloader.DownloadProgressChanged += OnDownloadProgressChanged;
            _downloader.StartDownload();
            yield return _downloader;

            // 下载失败：状态文本显示失败原因并停止
            if (_downloader.Status != EOperationStatus.Succeeded)
            {
                SetUIState($"下载失败：{_downloader.Error}");
                Debug.LogError($"[Load] Download files failed : {_downloader.Error}");
                _running = false;
                yield break;
            }

            // ---- 5. 下载完成：100% + "加载中"，随后加载程序集并延迟 1.5s 进入 ----
            Debug.Log("[Load] Download files completed.");
            yield return StartCoroutine(EnterLoadStateAndRunHotUpdate());
        }
    }

    /// <summary>
    /// 进入"加载中"状态：100% -> 加载 AOT 元数据与热更程序集 -> 延迟 1.5s -> 调用入口。
    /// </summary>
    private IEnumerator EnterLoadStateAndRunHotUpdate()
    {
        SetUIProgress(1f);
        SetUIState(StateLoad);

        // 加载 AOT 补充元数据（来自 Inspector 配置的 aotMetaAssemblies 列表，
        // 需保证 Assets/HotUpdate/DLLs 下存在同名 .dll.bytes 原始文件）。
        var metaNames = new List<string>();
        if (aotMetaAssemblies != null)
        {
            foreach (var name in aotMetaAssemblies)
            {
                if (string.IsNullOrEmpty(name) == false)
                    metaNames.Add(NormalizeAssemblyName(name));
            }
        }

        foreach (var metaName in metaNames)
        {
            byte[] dllBytes = null;
            yield return StartCoroutine(LoadDllBytes(BuildDllLocation(metaName), bytes => dllBytes = bytes));
            if (dllBytes == null)
            {
                Debug.LogWarning($"[Load] Skip AOT meta assembly '{metaName}' because its raw file is missing.");
                continue;
            }

            var loadImageError = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, HomologousImageMode.SuperSet);
            if (loadImageError != LoadImageErrorCode.OK)
            {
                Debug.LogError($"[Load] Load AOT metadata '{metaName}' failed, error code : {loadImageError}");
            }
            else
            {
                Debug.Log($"[Load] Load AOT metadata '{metaName}' success.");
            }
        }

        // 加载热更程序集本体
        byte[] hotUpdateDllBytes = null;
        yield return StartCoroutine(LoadDllBytes(BuildDllLocation(hotUpdateAssemblyName), bytes => hotUpdateDllBytes = bytes));
        if (hotUpdateDllBytes == null)
        {
            SetUIState($"加载失败：未找到热更程序集 {hotUpdateAssemblyName}");
            Debug.LogError($"[Load] Hot update assembly '{hotUpdateAssemblyName}' is missing.");
            _running = false;
            yield break;
        }

        Assembly hotUpdateAssembly;
        Type entryType;
        MethodInfo entryMethod;
        try
        {
        // #if !UNITY_EDITOR
        //     hotUpdateAssembly = Assembly.Load(hotUpdateDllBytes);
        // #else
        //     hotUpdateAssembly = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "HotUpdate");
        // #endif
            hotUpdateAssembly = Assembly.Load(hotUpdateDllBytes);
            Debug.Log($"[Load] Load hot update assembly '{hotUpdateAssemblyName}' success.");

            entryType = hotUpdateAssembly.GetType(hotUpdateEntryType);
            if (entryType == null)
                throw new Exception($"Entry type '{hotUpdateEntryType}' was not found in assembly.");

            entryMethod = entryType.GetMethod(hotUpdateEntryMethod, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (entryMethod == null)
                throw new Exception($"Entry method '{hotUpdateEntryType}.{hotUpdateEntryMethod}' was not found.");
        }
        catch (Exception e)
        {
            SetUIState($"加载失败：{e.Message}");
            Debug.LogError($"[Load] Prepare hot update entry failed : {e}");
            _running = false;
            yield break;
        }

        // ---- 6. 延迟 1.5s 再执行入口方法（期间状态文本保持"加载中"） ----
        Debug.Log("[Load] Wait 1.5 seconds before invoking hot update entry.");
        yield return new WaitForSeconds(1.5f);

        try
        {
            entryMethod.Invoke(null, null);
            Debug.Log($"[Load] Invoke '{hotUpdateEntryType}.{hotUpdateEntryMethod}' success.");
        }
        catch (Exception e)
        {
            SetUIState($"进入游戏失败:{e.InnerException?.Message ?? e.Message}");
            Debug.LogError($"[Load] Invoke hot update entry failed : {e}");
        }
        finally
        {
            _running = false;
        }
    }

    /// <summary>
    /// 创建并初始化资源包（按官方 Space Shooter 示例的四种运行模式初始化）。
    /// </summary>
    private IEnumerator InitializePackage()
    {
        if (!YooAssets.TryGetPackage(packageName, out _package))
            _package = YooAssets.CreatePackage(packageName);

        InitializePackageOperation initializeOperation = null;

        // 编辑器模拟模式
        if (playMode == EPlayMode.EditorSimulateMode)
        {
            var buildResult = EditorSimulateBuildInvoker.Build(packageName, (int)EBundleType.VirtualAssetBundle);
            string packageRoot = buildResult.PackageRootDirectory;
            var createParameters = new EditorSimulateModeOptions();
            createParameters.EditorFileSystemParameters = FileSystemParameters.CreateDefaultEditorFileSystemParameters(packageRoot);
            createParameters.EditorFileSystemParameters.AddParameter(EFileSystemParameter.VirtualWebglMode, true);
            createParameters.EditorFileSystemParameters.AddParameter(EFileSystemParameter.VirtualDownloadMode, true);
            createParameters.EditorFileSystemParameters.AddParameter(EFileSystemParameter.VirtualDownloadSpeed, 1024 * 1000 * 10);
            createParameters.EditorFileSystemParameters.AddParameter(EFileSystemParameter.AsyncSimulateMinFrame, 5);
            createParameters.EditorFileSystemParameters.AddParameter(EFileSystemParameter.AsyncSimulateMaxFrame, 10);
            initializeOperation = _package.InitializePackageAsync(createParameters);
        }

        // 离线运行模式
        if (playMode == EPlayMode.OfflinePlayMode)
        {
            var createParameters = new OfflinePlayModeOptions();
            createParameters.BuiltinFileSystemParameters = FileSystemParameters.CreateDefaultBuiltinFileSystemParameters();
            initializeOperation = _package.InitializePackageAsync(createParameters);
        }

        // 联机运行模式（最常用：内置包 + 远端 CDN 热更）
        if (playMode == EPlayMode.HostPlayMode)
        {
            if (string.IsNullOrEmpty(defaultHostServer))
            {
                SetUIState("校验失败：未配置资源服务器地址");
                Debug.LogError("[Load] defaultHostServer is empty.");
                _running = false;
                yield break;
            }

            IRemoteService remoteService = new RemoteService(defaultHostServer, fallbackHostServer);
            var createParameters = new HostPlayModeOptions();
            createParameters.BuiltinFileSystemParameters = FileSystemParameters.CreateDefaultBuiltinFileSystemParameters();
            createParameters.BuiltinFileSystemParameters.AddParameter(EFileSystemParameter.CopyBuiltinPackageManifest, true);
            createParameters.CacheFileSystemParameters = FileSystemParameters.CreateDefaultSandboxFileSystemParameters(remoteService);
            initializeOperation = _package.InitializePackageAsync(createParameters);
        }

        // WebGL 运行模式
        if (playMode == EPlayMode.WebPlayMode)
        {
            var createParameters = new WebPlayModeOptions();
            createParameters.WebServerFileSystemParameters = FileSystemParameters.CreateDefaultWebServerFileSystemParameters();
            initializeOperation = _package.InitializePackageAsync(createParameters);
        }

        if (initializeOperation == null)
        {
            SetUIState($"校验失败：不支持运行模式 {playMode}");
            Debug.LogError($"[Load] Unsupported play mode : {playMode}");
            _running = false;
            yield break;
        }

        yield return initializeOperation;
        if (initializeOperation.Status != EOperationStatus.Succeeded)
        {
            SetUIState($"校验失败：{initializeOperation.Error}");
            Debug.LogError($"[Load] Initialize package failed : {initializeOperation.Error}");
            _running = false;
        }
    }

    // ======================= UI 转发（具体表现逻辑在面板脚本内） =======================

    /// <summary>进度更新转发到 HotUpdatePanel（进度条/百分比格式化由面板负责）</summary>
    private void SetUIProgress(float value)
    {
        if (updatePanel != null)
            updatePanel.SetProgress(value);
    }

    /// <summary>状态文本转发到 HotUpdatePanel</summary>
    private void SetUIState(string state)
    {
        if (updatePanel != null)
            updatePanel.SetState(state);
    }

    /// <summary>下载进度事件：进度条与文本跟随下载进度（对应需求步骤 4）</summary>
    private void OnDownloadProgressChanged(DownloadProgressChangedEventArgs args)
    {
        SetUIProgress(args.Progress);
    }

    private void OnSureButton()
    {
        _userSure = true;
    }

    private void OnQuitButton()
    {
        _userQuit = true;
    }

    /// <summary>退出游戏（编辑器下停止播放）</summary>
    private void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    /// <summary>去掉程序集扩展名，统一为纯程序集名</summary>
    private static string NormalizeAssemblyName(string assemblyName)
    {
        if (assemblyName.EndsWith(".dll", StringComparison.Ordinal))
            assemblyName = assemblyName.Substring(0, assemblyName.Length - 4);
        return assemblyName;
    }

    /// <summary>
    /// 计算 DLL 原始文件的定位地址。
    /// Assets/HotUpdate/DLLs/HotUpdate.dll.bytes 按"文件夹名_文件名"规则寻址为 DLLs_HotUpdate.dll。
    /// </summary>
    private static string BuildDllLocation(string assemblyName)
    {
        return $"{DllLocationPrefix}{NormalizeAssemblyName(assemblyName)}.dll";
    }

    /// <summary>
    /// 通过 YooAsset 加载原生文件字节。
    /// .dll 以 .bytes 结尾时为 TextAsset（常规打包管线）；若以 RawBundle 打包则为 RawFileObject，二者依次尝试。
    /// </summary>
    private IEnumerator LoadDllBytes(string location, Action<byte[]> callback)
    {
        if (_package == null)
        {
            callback?.Invoke(null);
            yield break;
        }

        // 尝试一：TextAsset（常规 AssetBundle 打包的 .bytes 文件）
        var textHandle = _package.LoadAssetAsync<TextAsset>(location);
        yield return textHandle;
        if (textHandle.Status == EOperationStatus.Succeeded && textHandle.AssetObject is TextAsset textAsset)
        {
            byte[] data = textAsset.bytes;
            textHandle.Release();
            callback?.Invoke(data);
            yield break;
        }
        textHandle.Release();

        // 尝试二：RawFileObject（原生文件管线打包）
        var rawHandle = _package.LoadAssetAsync<RawFileObject>(location);
        yield return rawHandle;
        if (rawHandle.Status == EOperationStatus.Succeeded && rawHandle.AssetObject is RawFileObject rawFileObject)
        {
            byte[] data = rawFileObject.GetBytes();
            rawHandle.Release();
            callback?.Invoke(data);
            yield break;
        }
        rawHandle.Release();

        Debug.LogWarning($"[Load] Load dll bytes failed at location '{location}' : {textHandle.Error}");
        callback?.Invoke(null);
    }

    /// <summary>
    /// 远端资源 URL 服务（参考官方 Space Shooter 示例 RemoteService）。
    /// </summary>
    private class RemoteService : IRemoteService
    {
        private readonly List<string> _remoteUrls = new List<string>();

        public RemoteService(string defaultHostServer, string fallbackHostServer)
        {
            if (string.IsNullOrEmpty(defaultHostServer) == false)
                _remoteUrls.Add(defaultHostServer);
            if (string.IsNullOrEmpty(fallbackHostServer) == false)
                _remoteUrls.Add(fallbackHostServer);
        }

        public IReadOnlyList<string> GetRemoteUrls(string fileName)
        {
            List<string> result = new List<string>(_remoteUrls.Count);
            foreach (var url in _remoteUrls)
                result.Add($"{url}/{fileName}");
            return result;
        }
    }
}