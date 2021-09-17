using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour
{
    private ObjectManager m_objectManager;

    protected virtual void Start()
    {
        TryInit();
    }

    protected virtual void TryInit()
    {
    }
}
