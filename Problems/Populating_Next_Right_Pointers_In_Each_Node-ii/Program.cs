using System;

namespace Populating_Next_Right_Pointers_In_Each_Node_ii
{
    using Common;

    class Program
    {
        static void Main(string[] args)
        {
            //Test(TreeLinkNode.GetTree());
            Console.WriteLine();
            Test(TreeLinkNode.GetTree2());
            Console.ReadKey(true);
        }

        static void Test(TreeLinkNode root)
        {
            var solution = new Solution();
            solution.Connect(root);
            TreeLinkNode.ShowTree(root);
        }
    }
}
