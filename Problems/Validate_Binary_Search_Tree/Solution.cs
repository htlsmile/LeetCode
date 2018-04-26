using System;
using System.Collections.Generic;
using System.Text;

namespace Validate_Binary_Search_Tree
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
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            var left = root.left;
            var right = root.right;
            if (left != null)
            {
                while (left.right != null)
                {
                    left = left.right;
                }
            }
            if (right != null)
            {
                while (right.left != null)
                {
                    right = right.left;
                }
            }
            return (left == null || (left.val < root.val && IsValidBST(root.left))) &&
               (right == null || (right.val > root.val && IsValidBST(root.right)));
        }
    }
}
