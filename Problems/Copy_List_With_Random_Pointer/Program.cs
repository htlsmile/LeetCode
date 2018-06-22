using System;
using Common;
using static Common.RandomListNode;

namespace Copy_List_With_Random_Pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(GetRandomListNode());
            Console.ReadKey(true);
        }

        static void Test(RandomListNode head)
        {
            var solution = new Solution();
            var result = solution.CopyRandomList(head);
            ShowRandomListNode(result);
        }
    }
}
