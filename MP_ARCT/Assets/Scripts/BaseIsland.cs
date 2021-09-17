using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseIsland : BaseObject
{
    [SerializeField] private int _ID;
    [SerializeField] private float _totalExecutionTime;
    [SerializeField] private List<BaseModule> m_ModuleContainer;

    public float TotalExecutionTime
    {
        get => _totalExecutionTime;
        set => _totalExecutionTime = value;
    }

}
