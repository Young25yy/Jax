using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : BasePanel
{
    public Slider enemyHPSlider;
    public Slider playerHPSlider;
    public Image QImage;
    public Image EImage;
    public Image RImage;
    public Image TImage;
    void OnEnable()
    {
        EventCenter.Instance.AddListener<float>(EventType.EnemyHPChange, EnemyHPChange);
        EventCenter.Instance.AddListener<float>(EventType.PlayerHPChange, PlayerHPChange);
        EventCenter.Instance.AddListener<SkillCDData>(EventType.SkillCDChange, SkillDataChange);
    }
    void OnDisable()
    {
        EventCenter.Instance.RemoveListener<float>(EventType.EnemyHPChange, EnemyHPChange);
        EventCenter.Instance.RemoveListener<float>(EventType.PlayerHPChange, PlayerHPChange);
    }
    void EnemyHPChange(float value)
    {
        enemyHPSlider.value = value;
    }
    void PlayerHPChange(float value)
    {
        playerHPSlider.value = value;
    }
    void SkillDataChange(SkillCDData data)
    {
        QImage.fillAmount = data.QPercent;
        EImage.fillAmount = data.EPercent;
        RImage.fillAmount = data.RPercent;
        TImage.fillAmount = data.TPercent;
    }
    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            await UIManager.Instance.ShowPanel<InnerSettingPanel>();
        }
    }
}
