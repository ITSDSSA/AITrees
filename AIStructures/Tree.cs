using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nodes;

namespace Trees
{
    class Tree
    {
        public TreeNode root; 
        
        public TreeNode insert(TreeNode toPlace, int val)
        {
            if (toPlace == null)
            {
                toPlace = new TreeNode();
                toPlace.Val = val;
                if (root == null) root = toPlace;
                return toPlace;
            }
        
            else if (val <= toPlace.Val)
            {
                toPlace.left = insert(toPlace.left, val);
            }
            else
            {
                toPlace.right = insert(toPlace.right, val);
            }
            return toPlace;
        }
        
        public void treePrint(TreeNode node)
        {
            if (node != null)
                treePrint(node.left);
            if(node != null)
            System.Console.WriteLine("{0}", node.Val);
            if(node != null)
            treePrint(node.right);
        }    

        public TreeNode Find(TreeNode Node, int val)
        {
            if(Node == null)
                return null;
            if (Node.Val == val)
                return Node;
            else if (val < Node.Val)
                return(Find(Node.left, val));
            else
                return(Find(Node.right, val));
        }
    }
    


    class TreeNode: INode<TreeNode>
    {
        public TreeNode left;
        public TreeNode right;
        public string id;

        public int Val;

        public int Evaluate(TreeNode node)
        {
            return Val;
        }

        public List<TreeNode> getSuccessors(TreeNode node)
        {
            return new List<TreeNode>() { left, right };
        }

        public override string ToString()
        {
            return "id:" + id + " Val:" + Val.ToString();
        }
    }
}
