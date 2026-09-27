using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingData
{
    public float musicVolume;
    public float soundVolume;
    public bool isMusicOn;
    public bool isSoundOn;
    public SettingData()
    {
        musicVolume = 0.5f;
        soundVolume = 0.5f;
        isMusicOn = true;
        isSoundOn = true;
    }
}
