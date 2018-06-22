using System;
using Common;
using static Common.ListNode;

namespace Sort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(GetListNode(4, 2, 1, 3));
            Test(GetListNode(-1, 5, 3, 4, 0));
            Console.ReadKey(true);
        }

        static void Test(ListNode head)
        {
            var solution = new Solution();
            var result = solution.SortList(head);
            ShowListNode(result);
        }
    }
}
