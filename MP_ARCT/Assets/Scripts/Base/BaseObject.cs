using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour
{
    private ObjectManager m_ObjectManager;

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

    protected virtual bool TryInitialize()
    {
        m_ObjectManager = ObjectManager.Instance;

        return true;
    }
}
