using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree_Level_Order_Traversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            var q1 = new Queue<TreeNode>();
            var q2 = new Queue<TreeNode>();
            if (root != null)
            {
                q1.Enqueue(root);
            }
            var list = new List<int>();
            while (q1.Count > 0)
            {
                var node = q1.Dequeue();
                list.Add(node.val);
                if (node.left != null)
                {
                    q2.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q2.Enqueue(node.right);
                }
                if (q1.Count == 0)
                {
                    result.Add(new List<int>(list));
                    list.Clear();
                    q1 = new Queue<TreeNode>(q2);
                    q2.Clear();
                }
            }
            return result;
        }
    }
}
