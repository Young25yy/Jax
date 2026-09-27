using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 热更进度面板：集中管理进度条、进度文本与状态文本的 UI 表现逻辑。
/// </summary>
public class HotUpdatePanel : MonoBehaviour
{
    public Slider progressSlider;//进度条
    public TMP_Text progressText;//进度文本
    public TMP_Text stateText;//状态文本

    /// <summary>显示面板</summary>
    public void Show()
    {
        gameObject.SetActive(true);
    }

    /// <summary>隐藏面板</summary>
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    /// <summary>
    /// 设置进度（0~1），同步更新进度条与百分比文本。
    /// </summary>
    public void SetProgress(float value)
    {
        value = Mathf.Clamp01(value);
        if (progressSlider != null)
            progressSlider.value = value;
        if (progressText != null)
            progressText.text = $"{Mathf.RoundToInt(value * 100)}%";
    }

    /// <summary>设置状态文本（如"校验中""下载中""加载中"）</summary>
    public void SetState(string state)
    {
        if (stateText != null)
            stateText.text = state;
    }
}
