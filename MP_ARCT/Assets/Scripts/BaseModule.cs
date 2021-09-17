using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseModule : BaseObject
{
    [SerializeField] private float _executionTime;
    public float ExecutionTime
    {
        get => _executionTime;
        set 
        {
            if (value > 0f)
            {
                _executionTime = value;                
            }

            else
            {
                print("Error : Time has to be over than 0!");                
            }
        }        
    }

}