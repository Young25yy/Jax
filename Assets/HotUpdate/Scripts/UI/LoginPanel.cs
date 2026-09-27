using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

public class LoginPanel : BasePanel
{
    public TMP_InputField accountInput;
    public TMP_InputField passwordInput;
    public Button loginBtn;
    public Button registerBtn;
    public Toggle rmbAccountTog;
    public Toggle rmbPasswordTog;
    async void Start()
    {
        accountInput.text = GameDataManager.Instance.loginData.lastAccount;
        passwordInput.text = GameDataManager.Instance.loginData.lastPassword;
        rmbAccountTog.isOn = GameDataManager.Instance.loginData.isRmbAccount;
        rmbPasswordTog.isOn = GameDataManager.Instance.loginData.isRmbPassword;
        if (!rmbAccountTog.isOn)
        {
            accountInput.text = "";
            passwordInput.text = "";
        }
        else
        {
            if (!rmbPasswordTog.isOn)
            {
                passwordInput.text = "";
            }
        }
        rmbAccountTog.onValueChanged.AddListener(async (value) =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            if (value == false)
            {
                rmbPasswordTog.isOn = false;
            }
        });
        rmbPasswordTog.onValueChanged.AddListener(async (value) =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            if (!rmbAccountTog.isOn)
            {
                rmbPasswordTog.isOn = false;
            }
        });
        loginBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            Login();
        });
        registerBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            await UIManager.Instance.ShowPanel<RegisterPanel>();
            UIManager.Instance.HidePanel<LoginPanel>();
        });
    }
    async void Login()
    {
        if (accountInput.text == "")
        {
            (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("请输入账号");
        }
        else if(GameDataManager.Instance.playerDatas.Find(playerData => playerData.account == accountInput.text) is PlayerData playerData)
        {
            if(passwordInput.text == "")
            {
                (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("请输入密码");
            }
            else if(passwordInput.text == playerData.password)
            {
                print("成功");
                GameDataManager.Instance.nowPlayerData = playerData;
                GameDataManager.Instance.loginData.lastAccount = accountInput.text;
                GameDataManager.Instance.loginData.lastPassword = passwordInput.text;
                GameDataManager.Instance.loginData.isRmbAccount = rmbAccountTog.isOn;
                GameDataManager.Instance.loginData.isRmbPassword = rmbPasswordTog.isOn;
                GameDataManager.Instance.SaveLoginData();
                UIManager.Instance.HidePanel<LoginPanel>();
                var package = YooAssets.GetPackage("DefaultPackage");
                var handle = package.LoadSceneAsync("Scenes_Start");
                handle.Completed += async (handle) =>
                {
                    handle.Release();
                    await UIManager.Instance.SetCanvas();
                    await UIManager.Instance.ShowPanel<StartPanel>();
                };
            }
            else
            {
                (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("密码错误");
            }
        }
        else
        {
            (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("账号不存在");
        }
    }
}
