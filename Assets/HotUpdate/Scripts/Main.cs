using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    async void Start()
    {
        await GameDataManager.Instance.Init();
        await UIManager.Instance.SetCanvas();
        AudioManager.Instance.SetAudioRoot();
        await AudioManager.Instance.PlayMusic("BackMusic_Start");
        await UIManager.Instance.ShowPanel<LoginPanel>();
    }
}