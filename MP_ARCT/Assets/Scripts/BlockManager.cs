using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : Singleton<BlockManager>
{
    [SerializeField] private BlockCompiler m_blockCompiler;

    public Tree<Block> blocks = new Tree<Block>();

    public void Compile()
    {
        var levelTree = blocks.LevelTraversal();

        levelTree.ForEach(leaf => m_blockCompiler.CompileBlock(leaf.info));
    }
}
