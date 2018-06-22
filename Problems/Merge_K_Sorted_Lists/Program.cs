using System;
using Common;
using static Common.ListNode;

namespace Merge_K_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode[] lists = { GetListNode(1, 4, 5), GetListNode(1, 3, 4), GetListNode(2, 6) };
            Test(lists);
            ListNode[] lists1 = { GetListNode() };
            Test(lists1);
            Console.ReadKey(true);
        }

        static void Test(ListNode[] lists)
        {
            var solution = new Solution();
            var result = solution.MergeKLists(lists);
            ShowListNode(result);
        }
    }
}
