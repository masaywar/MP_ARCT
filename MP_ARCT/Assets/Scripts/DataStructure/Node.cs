using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node<T>
{
    public int level;
    public Node<T> parent;
    public List<Node<T>> branches = new List<Node<T>>();
    public Tree<T> rootTree;
    public T info;
    
    public int branchCount
    {
        get=>branches.Count;
    }

    public bool isRoot
    {
        get => parent == null;
    }

    public bool isExternal
    {
        get => branchCount == 0;
    }

    public bool isInternal
    {
        get => !isExternal;
    }

    public Node(Tree<T> tree, T info, Node<T> parent=null)
    {
        this.rootTree = tree;
        this.info = info;

        if (parent != null)
        {
            level = parent.level + 1;
        }
        
        tree.height = Math.Max(tree.height, level);
    }
}

   
