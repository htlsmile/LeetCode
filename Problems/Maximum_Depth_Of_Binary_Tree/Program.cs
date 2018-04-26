using System;

namespace Maximum_Depth_Of_Binary_Tree
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
            var result = solution.MaxDepth(root);
            Console.WriteLine(result);
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
    }
}
