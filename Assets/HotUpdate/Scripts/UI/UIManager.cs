using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using YooAsset;
using UnityEngine.Rendering.Universal;

public class UIManager
{
    private static UIManager instance = new UIManager();
    public static UIManager Instance => instance;
    public Dictionary<string, BasePanel> panelDic = new Dictionary<string, BasePanel>();
    public Canvas canvas;
    public Camera UICamera;
    async public UniTask SetCanvas()
    {
        if (canvas == null)
        {
            var package = YooAssets.GetPackage("DefaultPackage");
            var assetHandle = package.LoadAssetAsync<GameObject>("Prefabs_Canvas");
            await assetHandle;
            var insHandle = assetHandle.InstantiateAsync();
            await insHandle;
            canvas = insHandle.Result.GetComponent<Canvas>();
            UICamera = canvas.worldCamera;
            GameObject.DontDestroyOnLoad(canvas.gameObject);
        }
        Camera.main.GetUniversalAdditionalCameraData().cameraStack.Add(UICamera);
    }

    public async UniTask<T> ShowPanel<T>() where T : BasePanel
    {
        string panelName = typeof(T).Name;
        if (panelDic.ContainsKey(panelName))
        {
            T panel = panelDic[panelName] as T;
            panel.gameObject.SetActive(true);
            panel.transform.SetParent(canvas.transform);
            panel.transform.SetAsLastSibling();
            panel.Show();
            return panel;
        }
        else
        {
            var package = YooAssets.GetPackage("DefaultPackage");
            var assetHandle = package.LoadAssetAsync<GameObject>("Panels_" + panelName);
            await assetHandle;
            var insHandle = assetHandle.InstantiateAsync(new InstantiateOptions(true, canvas.transform, false));
            await insHandle;
            T panel = insHandle.Result.GetComponent<T>();
            assetHandle.Release();
            panel.gameObject.SetActive(true);
            panelDic.Add(panelName, panel);
            panel.transform.SetAsLastSibling();
            panel.Show();
            return panel;
        }
    }

    public void HidePanel<T>() where T : BasePanel
    {
        string panelName = typeof(T).Name;
        if (panelDic.ContainsKey(panelName))
        {
            T panel = panelDic[panelName] as T;
            panel.Hide();
            panel.gameObject.SetActive(false);
        }
    }
}
