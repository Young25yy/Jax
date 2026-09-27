using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;

public class HotUpdateEntry
{
    public static void Entry()
    {
        var package = YooAssets.GetPackage("DefaultPackage");
        var handle = package.LoadSceneAsync("Scenes_Login", LoadSceneMode.Single);
    }
}
