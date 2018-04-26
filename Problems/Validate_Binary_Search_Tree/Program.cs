using System;

namespace Validate_Binary_Search_Tree
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
            var result = solution.IsValidBST(root);
            Console.WriteLine(result);
        }

        static TreeNode GetTree()
        {
            var tree = new TreeNode(10)
            {
                left = new TreeNode(5),
                right = new TreeNode(15)
                {
                    left = new TreeNode(8),
                    right = new TreeNode(20)
                }
            };
            return tree;
        }
    }
}
