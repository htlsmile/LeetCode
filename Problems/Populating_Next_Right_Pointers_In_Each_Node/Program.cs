using System;

namespace Populating_Next_Right_Pointers_In_Each_Node
{
    using Common;

    class Program
    {
        static void Main(string[] args)
        {
            Test(TreeLinkNode.GetPerfectTree());
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
