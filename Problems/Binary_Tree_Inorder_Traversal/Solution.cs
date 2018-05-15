using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree_Inorder_Traversal
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
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            Inorder(result, root);
            return result;
        }

        private void Inorder(IList<int> list, TreeNode node)
        {
            if (node != null)
            {
                Inorder(list, node.left);
                list.Add(node.val);
                Inorder(list, node.right);
            }
        }
    }
}