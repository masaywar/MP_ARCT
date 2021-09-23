using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestModule : BaseModule
{
    protected override void Awake() 
    {
        base.Awake();
    }

    public override void ModuleAction()
    {
        print("Hello World!");
    }
}
