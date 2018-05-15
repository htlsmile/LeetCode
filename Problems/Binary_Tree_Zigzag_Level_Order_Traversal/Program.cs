using System;
using System.Collections.Generic;

namespace Binary_Tree_Zigzag_Level_Order_Traversal
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
            var result = solution.ZigzagLevelOrder(root);
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

        static void ShowOrder(IList<IList<int>> orders)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < orders[i].Count; j++)
                {
                    Console.Write($"{orders[i][j]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
