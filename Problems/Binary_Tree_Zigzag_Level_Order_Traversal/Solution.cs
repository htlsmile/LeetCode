using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree_Zigzag_Level_Order_Traversal
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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            Zigzag(root, result, 0);
            return result;
        }

        private void Zigzag(TreeNode node, List<IList<int>> result, int level)
        {
            if (node == null)
            {
                return;
            }
            if (result.Count <= level)
            {
                result.Add(new List<int>());
            }
            if (level % 2 == 0)
            {
                result[level].Add(node.val);
            }
            else
            {
                result[level].Insert(0, node.val);
            }
            Zigzag(node.left, result, level + 1);
            Zigzag(node.right, result, level + 1);
        }
    }
}