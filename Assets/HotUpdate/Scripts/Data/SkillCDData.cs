using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SkillCDData
{
    public float QPercent;
    public float EPercent;
    public float RPercent;
    public float TPercent;
    public void SetData(float QPercent, float EPercent, float RPercent, float TPercent)
    {
        this.QPercent = QPercent;
        this.EPercent = EPercent;
        this.RPercent = RPercent;
        this.TPercent = TPercent;
    }
}
