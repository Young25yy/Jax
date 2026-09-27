using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegisterPanel : BasePanel
{
    public TMP_InputField accountInput;
    public TMP_InputField passwordInput;
    public TMP_InputField nameInput;
    public Button registerBtn;
    public Button backBtn;
    void Start()
    {
        registerBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            Register();
        });
        backBtn.onClick.AddListener(async ()=>
        {
            await AudioManager.Instance.PlaySound("Click1");
            await UIManager.Instance.ShowPanel<LoginPanel>();
            UIManager.Instance.HidePanel<RegisterPanel>();
        });
    }
    async void Register()
    {
        if (accountInput.text == "")
        {
            (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("请输入账号");
        }
        else if(GameDataManager.Instance.playerDatas.Find(playerData => playerData.account == accountInput.text) is PlayerData)
        {
            (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("账号已存在");
        }
        else
        {
            if(passwordInput.text == "")
            {
                (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("请输入密码");
            }
            else if(nameInput.text == "")
            {
                (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("请输入用户名");
            }
            else if(GameDataManager.Instance.playerDatas.Find(playerData => playerData.name == nameInput.text) is PlayerData)
            {
                (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("用户名已使用");
            }
            else
            {
                GameDataManager.Instance.playerDatas.Add(new PlayerData(accountInput.text, passwordInput.text, nameInput.text));
                GameDataManager.Instance.SavePlayerDatas();
                await UIManager.Instance.ShowPanel<LoginPanel>();
                UIManager.Instance.HidePanel<RegisterPanel>();
                (await UIManager.Instance.ShowPanel<TipPanel>()).SetInfo("注册成功");
            }
        }
    }
    public override void Show()
    {
        base.Show();
        accountInput.text = "";
        passwordInput.text = "";
        nameInput.text = "";
    }
}
