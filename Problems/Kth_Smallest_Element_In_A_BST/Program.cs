using System;

namespace Kth_Smallest_Element_In_A_BST
{
    using Common;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Test(BinaryTree.GetTestSearchTree(), i);
            }
            Console.ReadKey(true);
        }

        static void Test(TreeNode root, int k)
        {
            var solution = new Solution();
            var result = solution.KthSmallest(root, k);
            Console.WriteLine(result);
        }
    }
}
