using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCompiler : MonoBehaviour 
{
    public void CompileBlocks(Block[] blocks)
    {
        foreach(var block in blocks)
        {
#if UNITY_EDITOR
            block.TestAction();
#endif
        }
    }

    public void CompileBlock(Block block)
    {
#if UNITY_EDITOR
        block.TestAction();
#endif
        block.BlockAction();
    }
}

