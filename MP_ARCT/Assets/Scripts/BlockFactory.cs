using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class BlockFactory : MonoBehaviour
{
    [SerializeField] private List<Block> blockList = new List<Block>(); 

    public T InstantiateBlock<T>(int input, int output) where T : Block
    {   
        T block = Instantiate<T>((T)blockList[input*3 + (output-1)]);
        return block;
    }

    public void SetBlockAttribute<T>() where T : Block
    {

    }
}
