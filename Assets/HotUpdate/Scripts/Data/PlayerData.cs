using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string account;
    public string password;
    public string name;
    public List<int> passedLevelsId;
    public PlayerData()
    {
        account = "";
        password = "";
        name = "";
        passedLevelsId = new List<int>();
    }
    public PlayerData(string account, string password, string name)
    {
        this.account = account;
        this.password = password;
        this.name = name;
        this.passedLevelsId = new List<int>();
    }
}
