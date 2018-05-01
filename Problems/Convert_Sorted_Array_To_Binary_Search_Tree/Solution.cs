using System;
using System.Collections.Generic;
using System.Text;

namespace Convert_Sorted_Array_To_Binary_Search_Tree
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
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return nums.Length == 0 ? null : SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBST(int[] nums, int low, int high)
        {
            if (low > high)
            {
                return null;
            }
            int mid = low + (high - low) / 2;
            TreeNode node = new TreeNode(nums[mid])
            {
                left = SortedArrayToBST(nums, low, mid - 1),
                right = SortedArrayToBST(nums, mid + 1, high)
            };
            return node;
        }
    }
}
