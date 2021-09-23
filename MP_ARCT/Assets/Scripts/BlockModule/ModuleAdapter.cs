using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttachedPosition
{
    Head, Tail
}

public class ModuleAdapter : MonoBehaviour
{
    [SerializeField] private AttachedPosition _attachedPosition;
    [SerializeField] private BaseModule m_Module;
    [SerializeField] private ModuleAdapter m_attachedAdapter;

    public AttachedPosition AttachedPos
    {
        get => _attachedPosition;
        set => _attachedPosition = value;
    }
/// <summary>
/// The Module which has this adapter. 
/// </summary>
/// <value></value>
    public BaseModule Module
    {
        get => m_Module;
        set => m_Module = value;
    }

/// <summary>
/// The other Adapter which is connected to this adapter. 
/// </summary>
/// <value></value>
    public ModuleAdapter AttachedAdapter
    {
        get => m_attachedAdapter;
        set => m_attachedAdapter = value;
    }

    private void OnAdapterAttached(ModuleAdapter other)
    {
        if(other.AttachedPos != AttachedPos)
        {
            AttachedAdapter = other;
            other.Module = Module;
        }
    }    
}
