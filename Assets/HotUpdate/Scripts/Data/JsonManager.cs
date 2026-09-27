using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using LitJson;
using UnityEngine;

public class JsonManager
{
    private static JsonManager instance = new JsonManager();
    public static JsonManager Instance => instance;
    private JsonManager()
    {
        
    }
    public void SaveData(object data, string fileName)
    {
        string path = Application.streamingAssetsPath + "/Configs/" + fileName + ".json";
        string jsonStr = JsonMapper.ToJson(data);
        File.WriteAllTextAsync(path, jsonStr);
    }
    public async UniTask<T> LoadData<T>(string fileName) where T : class
    {
        string path = Application.streamingAssetsPath + "/Configs/" + fileName + ".json";
        string jsonStr;
        if (File.Exists(path))
        {
            jsonStr = await File.ReadAllTextAsync(path);
            return string.IsNullOrWhiteSpace(jsonStr) ? default(T) : JsonMapper.ToObject<T>(jsonStr);
        }
        return default(T);
    }
}
