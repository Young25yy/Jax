using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : BasePanel
{
    public Button backBtn;
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
        backBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            GameDataManager.Instance.SaveSettingData();
            UIManager.Instance.HidePanel<SettingPanel>();
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
}
