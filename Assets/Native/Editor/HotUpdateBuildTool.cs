using System.IO;
using UnityEditor;
using UnityEngine;

public static class HotUpdateBuildTool
{
    private const string SourceRoot = "HybridCLRData/HotUpdateDlls";
    private const string TargetDir = "Assets/HotUpdate/DLLs";

    [MenuItem("HybridCLR/复制热更Dll到Bundle")]
    public static void CopyHotUpdateDll()
    {
        var buildTarget = EditorUserBuildSettings.activeBuildTarget;
        string platformDir = GetPlatformDir(buildTarget);

        string src = Path.Combine(Directory.GetCurrentDirectory(), SourceRoot, platformDir, "HotUpdate.dll");
        if (!File.Exists(src))
        {
            EditorUtility.DisplayDialog("复制热更Dll", $"未找到热更dll：\n{src}\n\n请先执行 HybridCLR/CompileDll 生成热更dll", "确定");
            return;
        }

        string destDir = Path.Combine(Directory.GetCurrentDirectory(), TargetDir);
        Directory.CreateDirectory(destDir);

        string dest = Path.Combine(destDir, "HotUpdate.dll.bytes");
        File.Copy(src, dest, true);

        AssetDatabase.Refresh();
        Debug.Log($"已复制热更dll：{dest}");
        EditorUtility.DisplayDialog("复制热更Dll", $"已复制：\n{dest}", "确定");
    }

    private static string GetPlatformDir(BuildTarget target)
    {
        if (target == BuildTarget.StandaloneOSX)
            return "StandaloneOSX";
        return target.ToString();
    }
}