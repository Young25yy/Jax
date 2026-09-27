using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

public class LevelSelectPanel : BasePanel
{
    public List<LevelData> levelDatas;
    public List<LevelItem> levelItems;
    public Button backBtn;
    public ScrollRect scrollRect;
    async void Start()
    {
        backBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            await UIManager.Instance.ShowPanel<StartPanel>();
            UIManager.Instance.HidePanel<LevelSelectPanel>();
        });
        var package = YooAssets.GetPackage("DefaultPackage");
        var assetHandle = package.LoadAssetAsync<GameObject>("Prefabs_LevelItem");
        await assetHandle;
        foreach(var levelData in levelDatas)
        {
            var insHandle = assetHandle.InstantiateAsync(new InstantiateOptions(true, scrollRect.content.transform, false));
            await insHandle;
            LevelItem levelItem = insHandle.Result.GetComponent<LevelItem>();
            levelItems.Add(levelItem);
            levelItem.levelData = levelData;
            levelItem.SetLevelItem();
        }
        assetHandle.Release();
    }
    public override void Show()
    {
        base.Show();
        foreach(var levelItem in levelItems)
        {
            levelItem.SetLevelItem();
        }
    }
}
