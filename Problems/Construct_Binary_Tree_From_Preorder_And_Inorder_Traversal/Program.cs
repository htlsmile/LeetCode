using System;
using System.Collections.Generic;

namespace Construct_Binary_Tree_From_Preorder_And_Inorder_Traversal
{
    using Common;

    class Program
    {
        static void Main(string[] args)
        {
            int[] preorder = { 3, 9, 20, 15, 7 };
            int[] inorder = { 9, 3, 15, 20, 7 };
            Test(preorder, inorder);
            Console.ReadKey(true);
        }

        static void Test(int[] preorder, int[] inorder)
        {
            var solution = new Solution();
            var tree = solution.BuildTree(preorder, inorder);
            BinaryTree.PreorderTraversal(tree);
            Console.WriteLine();
            BinaryTree.InorderTraversal(tree);
            Console.WriteLine();
            BinaryTree.PostorderTraversal(tree);
            Console.WriteLine();
        }
    }
}
