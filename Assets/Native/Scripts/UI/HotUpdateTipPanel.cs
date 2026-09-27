using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 热更提示面板：集中管理"存在新版本"的提示文本与确认/退出按钮的 UI 表现逻辑。
/// </summary>
public class HotUpdateTipPanel : MonoBehaviour
{
    public TMP_Text infoText;//更新信息文本
    public Button sureBtn;//确认按钮
    public Button quitBtn;//退出按钮
    public AudioSource audioSource;
    private Action _onSure;
    private Action _onQuit;

    /// <summary>
    /// 弹出提示面板：设置提示文本并绑定确认/退出回调。
    /// </summary>
    /// <param name="info">提示信息</param>
    /// <param name="onSure">点击"确认"按钮的回调</param>
    /// <param name="onQuit">点击"退出"按钮的回调</param>
    public void ShowMessage(string info, Action onSure, Action onQuit)
    {
        _onSure = onSure;
        _onQuit = onQuit;

        if (infoText != null)
            infoText.text = info;
        if (sureBtn != null)
        {
            sureBtn.onClick.RemoveAllListeners();
            sureBtn.onClick.AddListener(() =>
            {
                audioSource.Play();
            });
            sureBtn.onClick.AddListener(OnSureClicked);
        }
        if (quitBtn != null)
        {
            quitBtn.onClick.RemoveAllListeners();
            quitBtn.onClick.AddListener(() =>
            {
                audioSource.Play();
            });
            quitBtn.onClick.AddListener(OnQuitClicked);
        }

        gameObject.SetActive(true);
    }

    /// <summary>隐藏提示面板并清空回调</summary>
    public void Hide()
    {
        gameObject.SetActive(false);
        _onSure = null;
        _onQuit = null;
    }

    private void OnSureClicked()
    {
        Action callback = _onSure;
        if (callback != null)
            callback.Invoke();
    }

    private void OnQuitClicked()
    {
        Action callback = _onQuit;
        if (callback != null)
            callback.Invoke();
    }
}
