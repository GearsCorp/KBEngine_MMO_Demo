using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KBEngine;

public class Account : AccountBase
{
    public override void __init__()
    {
        base.__init__();
        KBEngine.Event.fireOut("OnLoginSuccess");
        Debug.Log("Account::__init__() ...");
    }
}
