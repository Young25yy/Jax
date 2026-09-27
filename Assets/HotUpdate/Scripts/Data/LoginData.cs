using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginData
{
    public string lastAccount;
    public string lastPassword;
    public bool isRmbAccount;
    public bool isRmbPassword;
    public LoginData()
    {
        lastAccount = "";
        lastPassword = "";
        isRmbAccount = false;
        isRmbPassword = false;
    }
}
