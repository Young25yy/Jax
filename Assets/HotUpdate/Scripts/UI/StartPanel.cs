using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : BasePanel
{
    public Button startBtn;
    public Button settingBtn;
    public Button quitBtn;
    // public GameObject model;
    async void Start()
    {
        startBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            await UIManager.Instance.ShowPanel<LevelSelectPanel>();
            UIManager.Instance.HidePanel<StartPanel>();
        });
        settingBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            await UIManager.Instance.ShowPanel<SettingPanel>();
        });
        quitBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            Application.Quit();
        });
    }
}
