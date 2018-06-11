using System;
using Common;

namespace Serialize_And_Deserialize_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(null);
            Test(new TreeNode(0));
            Test(BinaryTree.GetTestTree());
            Console.ReadKey(true);
        }

        static void Test(TreeNode root)
        {
            var codec = new Codec();
            Console.WriteLine(codec.serialize(root));
            Console.WriteLine();
            var result = codec.deserialize(codec.serialize(root));
            Console.WriteLine("Origin");
            BinaryTree.PreorderTraversal(root);
            Console.WriteLine();
            BinaryTree.InorderTraversal(root);
            Console.WriteLine();
            BinaryTree.PostorderTraversal(root);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After");
            BinaryTree.PreorderTraversal(result);
            Console.WriteLine();
            BinaryTree.InorderTraversal(result);
            Console.WriteLine();
            BinaryTree.PostorderTraversal(result);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
