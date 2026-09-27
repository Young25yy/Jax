using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TipPanel : BasePanel
{
    public TMP_Text infoText;
    public Button sureBtn;
    void Start()
    {
        sureBtn.onClick.AddListener(async () =>
        {
            await AudioManager.Instance.PlaySound("Click1");
            UIManager.Instance.HidePanel<TipPanel>();
        });
    }
    public void SetInfo(string info)
    {
        infoText.text = info;
    }
}
