using System;
using System.Collections.Generic;

namespace Binary_Tree_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(GetTree());
            Console.ReadKey(true);
        }

        static void Test(TreeNode root)
        {
            var solution = new Solution();
            var result = solution.InorderTraversal(root);
            ShowOrder(result);
        }

        static TreeNode GetTree()
        {
            var tree = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            return tree;
        }

        static void ShowOrder(IList<int> orders)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Console.Write($"{orders[i]} ");
            }
            Console.WriteLine();
        }
    }
}
