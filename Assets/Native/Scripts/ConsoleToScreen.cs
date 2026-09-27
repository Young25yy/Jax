using System.Collections.Generic;
using UnityEngine;

public class ConsoleToScreen : MonoBehaviour
{
    private readonly List<string> _logs = new List<string>();
    private string _output = string.Empty;

    void OnEnable()
    {
        Application.logMessageReceived += OnLogMessageReceived;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= OnLogMessageReceived;
    }

    void OnLogMessageReceived(string condition, string stackTrace, LogType type)
    {
        _logs.Add($"[{type}] {condition}");
        if (_logs.Count > 50)
            _logs.RemoveAt(0);

        _output = string.Join("\n", _logs);
    }

    void OnGUI()
    {
        GUI.skin.label.fontSize = 20;
        GUI.Label(new Rect(10, 10, Screen.width - 20, Screen.height - 20), _output);
    }
}