using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
[CreateAssetMenu(fileName = "CharacterData", menuName = "SO/CharacterData")]
public class CharacterData : ScriptableObject
{
    public new string name;
    public float speed;
    public float attack;
    public float defense;
    public float maxHP;
    public float QCD;
    public float ECD;
    public float RCD;
    public float TCD;
    public float attackSpeed;
    public float attackCD;
}
