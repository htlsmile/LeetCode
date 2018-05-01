using System;

namespace Convert_Sorted_Array_To_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -10, -3, 0, 5, 9 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.SortedArrayToBST(nums);
            ShowTree(result);
        }

        static void ShowTree(TreeNode root)
        {
            if (root.left != null)
            {
                ShowTree(root.left);
            }
            Console.Write($"{root?.val} ");
            if (root.right != null)
            {
                ShowTree(root.right);
            }
        }
    }
}
