using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

public class InnerSettingPanel : BasePanel
{
    public Button continueBtn;
    public Button quitBtn;
    public Toggle musicTog;
    public Toggle soundTog;
    public Slider musicSlider;
    public Slider soundSlider;
    async public void Start()
    {
        musicTog.isOn = GameDataManager.Instance.settingData.isMusicOn;
        soundTog.isOn = GameDataManager.Instance.settingData.isSoundOn;
        musicSlider.value = GameDataManager.Instance.settingData.musicVolume;
        soundSlider.value = GameDataManager.Instance.settingData.soundVolume;
        continueBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            GameDataManager.Instance.SaveSettingData();
            UIManager.Instance.HidePanel<InnerSettingPanel>();
        });
        quitBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            GameDataManager.Instance.SaveSettingData();
            UIManager.Instance.HidePanel<InnerSettingPanel>();
            UIManager.Instance.HidePanel<GamePanel>();
            var package = YooAssets.GetPackage("DefaultPackage");
            var handle = package.LoadSceneAsync("Scenes_Start");
            handle.Completed += async (handle) =>
            {
                handle.Release();
                await UIManager.Instance.SetCanvas();
                await UIManager.Instance.ShowPanel<StartPanel>();
                await AudioManager.Instance.PlayMusic("BackMusic_Start");
                Cursor.lockState = CursorLockMode.None;
            };
        });
        musicTog.onValueChanged.AddListener(async (value) =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            GameDataManager.Instance.settingData.isMusicOn = value;
            AudioManager.Instance.SetMusicAudioSource();
        });
        soundTog.onValueChanged.AddListener(async (value) =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            GameDataManager.Instance.settingData.isSoundOn = value;
        });
        musicSlider.onValueChanged.AddListener((value) =>
        {
            GameDataManager.Instance.settingData.musicVolume = value;
            AudioManager.Instance.SetMusicAudioSource();
        });
        soundSlider.onValueChanged.AddListener((value) =>
        {
            GameDataManager.Instance.settingData.soundVolume = value;
        });
    }
    public override void Show()
    {
        base.Show();
        Time.timeScale = 0.1f;
        Cursor.lockState = CursorLockMode.None;
    }
    public override void Hide()
    {
        base.Hide();
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
