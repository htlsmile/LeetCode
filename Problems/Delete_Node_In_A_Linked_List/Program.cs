using System;

namespace Delete_Node_In_A_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            Console.ReadKey(true);
        }

        static void Test(ListNode node)
        {
            var solution = new Solution();
            solution.DeleteNode(node);
            Console.WriteLine("?");
        }
    }
}
