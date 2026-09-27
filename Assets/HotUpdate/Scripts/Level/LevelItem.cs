using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

public class LevelItem : MonoBehaviour
{
    public LevelData levelData;
    public Button enterBtn;
    public TMP_Text nameText;
    public Image backImage;
    public Image passedImage;
    async void Start()
    {
        enterBtn.onClick.AddListener(async () =>
        {
            GameDataManager.Instance.nowLevelData = levelData;
            await AudioManager.Instance.PlaySound("Level" + levelData.levelId + "_Selected");
            await UIManager.Instance.ShowPanel<GamePanel>();
            UIManager.Instance.HidePanel<LevelSelectPanel>();
            var package = YooAssets.GetPackage("DefaultPackage");
            var handle = package.LoadSceneAsync("Scenes_Level" + levelData.levelId);
            handle.Completed += async (handle) =>
            {
                handle.Release();
                await UIManager.Instance.SetCanvas();
                await AudioManager.Instance.PlaySound("Level" + levelData.levelId + "_In");
                await AudioManager.Instance.PlayMusic("BackMusic_Battle");
            };
        });
    }
    public void SetLevelItem()
    {
        nameText.text = levelData.levelName;
        backImage.sprite = levelData.levelSprite;
        if(GameDataManager.Instance.nowPlayerData.passedLevelsId.Contains(levelData.levelId))
        {
            passedImage.gameObject.SetActive(true);
        }
        else
        {
            passedImage.gameObject.SetActive(false);
        }
    }
}
