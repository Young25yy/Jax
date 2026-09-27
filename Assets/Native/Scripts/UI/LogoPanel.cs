using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LogoPanel : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.loopPointReached += (videoPlayer) =>
        {
            SceneManager.LoadScene("HotUpdate");
        };
    }
}
