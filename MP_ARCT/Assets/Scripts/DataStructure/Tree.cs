using System.Collections;
using System.Collections.Generic;

public class Tree<T>
{
    public Node<T> root;
    public int height = 0;

    public Tree(Node<T> root)
    {
        this.root = root; 
    }

    public Tree()
    {

    }

    public Node<T> GetNode()
    {
        return null;
    }

    public void AddBranch(Node<T> target, Node<T> added)
    {
        target.branches.Add(added);
    }

    public void RemoveBranch(Node<T> target, Node<T> deleted)
    {
        if (target.branchCount > 0)
        {
            target.branches.Remove(deleted);
        }
    }

    public Node<T>[] LevelTraversal()
    {
        Queue<Node<T>> queue = new Queue<Node<T>>();
        List<Node<T>> returnList = new List<Node<T>>();

        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var temp = queue.Dequeue();
            foreach(var branch in temp.branches)
            {
                queue.Enqueue(branch);
            }

            returnList.Add(temp);
        }

        return returnList.ToArray();
    }
}
