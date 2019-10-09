using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientApp : KBEMain
{
    private LoginPanel _LoginPanel;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
        _LoginPanel = new LoginPanel();
    }
}
