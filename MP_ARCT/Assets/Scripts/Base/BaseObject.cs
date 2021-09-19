using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour
{
    private ObjectManager mObjectManager;

    [SerializeField] private string mId;

    public string ID
    { 
        get => mId;
        set => mId = value;
    }

    protected virtual void Awake()
    {
        TryInitialize();
    }

    protected virtual void TryInitialize()
    {
        mObjectManager = ObjectManager.Instance;
    }
}
