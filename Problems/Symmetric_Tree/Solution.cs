using System;
using System.Collections.Generic;
using System.Text;

namespace Symmetric_Tree
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
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsMirror(root.left, root.right);
        }

        public bool IsMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null || t2 == null)
            {
                return t1 == t2;
            }
            return (t1.val == t2.val)
                && IsMirror(t1.right, t2.left)
                && IsMirror(t1.left, t2.right);
        }
    }
}
