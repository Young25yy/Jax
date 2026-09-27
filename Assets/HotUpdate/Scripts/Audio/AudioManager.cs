using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR;
using YooAsset;
public class AudioManager
{
    private static AudioManager instance = new AudioManager();
    public static AudioManager Instance => instance;
    public Dictionary<string, AudioClip> clipDic = new Dictionary<string, AudioClip>();
    public AudioSource musicAudioSource;
    public AudioSource soundAudioSource;
    public GameObject audioRoot;
    public void SetAudioRoot()
    {
        if (audioRoot == null)
        {
            audioRoot = new GameObject("AudioRoot");
            musicAudioSource = audioRoot.AddComponent<AudioSource>();
            soundAudioSource = audioRoot.AddComponent<AudioSource>();
            musicAudioSource.playOnAwake = false;
            musicAudioSource.loop = true;
            soundAudioSource.playOnAwake = false;
            GameObject.DontDestroyOnLoad(audioRoot);
        }
    }
    public void SetMusicAudioSource()
    {
        musicAudioSource.volume = GameDataManager.Instance.settingData.musicVolume;
        musicAudioSource.mute = !GameDataManager.Instance.settingData.isMusicOn;
    }
    async public UniTask PlayMusic(string clipName)
    {
        if (clipDic.ContainsKey(clipName))
        {
            musicAudioSource.clip = clipDic[clipName];
        }
        else
        {
            var package = YooAssets.GetPackage("DefaultPackage");
            var handle = package.LoadAssetAsync<AudioClip>("Audio_" + clipName);
            await handle;
            musicAudioSource.clip = handle.AssetObject as AudioClip;
            clipDic.Add(clipName, musicAudioSource.clip);
            handle.Release();
        }
        musicAudioSource.volume = GameDataManager.Instance.settingData.musicVolume;
        musicAudioSource.mute = !GameDataManager.Instance.settingData.isMusicOn;
        musicAudioSource.time = 0f;
        musicAudioSource.Play();
    }
    async public UniTask PlayMusic(AudioClip clip)
    {
        musicAudioSource.clip = clip;
        musicAudioSource.volume = GameDataManager.Instance.settingData.musicVolume;
        musicAudioSource.mute = !GameDataManager.Instance.settingData.isMusicOn;
        musicAudioSource.time = 0f;
        musicAudioSource.Play();
    }
    async public UniTask PlaySound(string clipName)
    {
        AudioClip clip;
        if (clipDic.ContainsKey(clipName))
        {
            clip = clipDic[clipName];
        }
        else
        {
            var package = YooAssets.GetPackage("DefaultPackage");
            var handle = package.LoadAssetAsync<AudioClip>("Audio_" + clipName);
            await handle;
            clip = handle.AssetObject as AudioClip;
            clipDic.Add(clipName, clip);
            handle.Release();
        }
        soundAudioSource.volume = GameDataManager.Instance.settingData.soundVolume;
        soundAudioSource.mute = !GameDataManager.Instance.settingData.isSoundOn;
        soundAudioSource.PlayOneShot(clip);
    }
    async public UniTask PlaySound(AudioClip clip)
    {
        soundAudioSource.volume = GameDataManager.Instance.settingData.soundVolume;
        soundAudioSource.mute = !GameDataManager.Instance.settingData.isSoundOn;
        soundAudioSource.PlayOneShot(clip);
    }
    async public UniTask PlaySoundAt(string clipName, GameObject obj)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        if(audioSource == null) audioSource = obj.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        AudioClip clip;
        if (clipDic.ContainsKey(clipName))
        {
            clip = clipDic[clipName];
        }
        else
        {
            var package = YooAssets.GetPackage("DefaultPackage");
            var handle = package.LoadAssetAsync<AudioClip>("Audio_" + clipName);
            await handle;
            clip = handle.AssetObject as AudioClip;
            clipDic.Add(clipName, clip);
            handle.Release();
        }
        audioSource.volume = GameDataManager.Instance.settingData.soundVolume;
        audioSource.mute = !GameDataManager.Instance.settingData.isSoundOn;
        audioSource.spatialBlend = 1;
        audioSource.PlayOneShot(clip);
    }
    async public UniTask PlaySoundAt(AudioClip clip, GameObject obj)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        if(audioSource == null) audioSource = obj.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.volume = GameDataManager.Instance.settingData.soundVolume;
        audioSource.mute = !GameDataManager.Instance.settingData.isSoundOn;
        audioSource.spatialBlend = 1;
        audioSource.PlayOneShot(clip);
    }
}
