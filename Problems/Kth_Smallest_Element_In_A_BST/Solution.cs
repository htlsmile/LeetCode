using System;
using System.Collections.Generic;
using System.Text;

namespace Kth_Smallest_Element_In_A_BST
{
    using Common;

    public class Solution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            int count = CountTreeNodes(root.left);
            if (k == count + 1)
            {
                return root.val;
            }
            else if (k <= count)
            {
                return KthSmallest(root.left, k);
            }
            else
            {
                return KthSmallest(root.right, k - count - 1);
            }
        }

        public int CountTreeNodes(TreeNode node)
        {
            return node == null ? 0 : CountTreeNodes(node.left) + CountTreeNodes(node.right) + 1;
        }
    }
}
