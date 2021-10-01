using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : UIC_Entity
{
    [SerializeField] int _numOfInput;
    [SerializeField] int _numOfOutput;

    private BlockManager m_BlockManager;

    public int InputCount
    {
        get => _numOfInput;
        set => _numOfInput = value;
    }

    public int OutputCount
    {
        get => _numOfOutput;
        set => _numOfOutput = value;
    }

    private void Awake()
    {
        m_BlockManager = BlockManager.Instance;
    }

    public virtual BlockOutput[] BlockAction()
    {
        return null;
    }

    public void OnAttached(Block block)
    {
        
    }

    public void OnDetached()
    {

    }

    public void TestAction()
    {
        string inputs = "";
        string outputs = "";

        foreach(var node in nodeList)
        {
            if (node.polarityType == UIC_Node.PolarityTypeEnum._in)
            {
                inputs += " " + node.name;
            }

            else if (node.polarityType == UIC_Node.PolarityTypeEnum._out)
            {
                outputs += " " + node.name;
            }
        }

        print(string.Format("In Node : {0}, Out Node : {1}", inputs, outputs));
    }
}
