using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using YooAsset;

public class GameDataManager
{
    private static GameDataManager instance = new GameDataManager();
    public static GameDataManager Instance => instance;
    public List<PlayerData> playerDatas = new List<PlayerData>();
    public PlayerData nowPlayerData;
    public LoginData loginData;
    public SettingData settingData;
    public LevelData nowLevelData;
    async public UniTask Init()
    {
        playerDatas = await JsonManager.Instance.LoadData<List<PlayerData>>("PlayerDatas");
        loginData = await JsonManager.Instance.LoadData<LoginData>("LoginData");
        settingData = await JsonManager.Instance.LoadData<SettingData>("SettingData");
        if(playerDatas == null) playerDatas = new List<PlayerData>();
        if(loginData == null) loginData = new LoginData();
        if(settingData == null) settingData = new SettingData();
    }
    public void SavePlayerDatas()
    {
        JsonManager.Instance.SaveData(playerDatas, "PlayerDatas");
    }
    public void SaveLoginData()
    {
        JsonManager.Instance.SaveData(loginData, "LoginData");
    }
    public void SaveSettingData()
    {
        JsonManager.Instance.SaveData(settingData, "SettingData");
    }
}
