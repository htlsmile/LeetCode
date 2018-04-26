using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Depth_Of_Binary_Tree
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
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int a = MaxDepth(root.left);
            int b = MaxDepth(root.right);
            return (a > b ? a : b) + 1;
        }
    }
}
