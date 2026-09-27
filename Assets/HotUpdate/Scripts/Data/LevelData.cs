using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
[CreateAssetMenu(fileName = "LevelData", menuName = "SO/LevelData")]
public class LevelData : ScriptableObject
{
    public int levelId;
    public string levelName;
    public Sprite levelSprite;
}
