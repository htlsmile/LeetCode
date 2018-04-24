using System;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = GetLinkedList(4);
            var l2 = GetLinkedList(3);
            Test(l1, l2);
            Console.ReadKey(true);
        }

        static void Test(ListNode l1, ListNode l2)
        {
            var solution = new Solution();
            var newHead = solution.MergeTwoLists(l1, l2);
            ShowLinkedList(newHead);
        }

        static ListNode GetLinkedList(int n = 5)
        {
            var head = new ListNode(1);
            var node = head;
            for (int i = 2; i <= n; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }
            return head;
        }

        static void ShowLinkedList(ListNode head)
        {
            var node = head;
            while (node != null)
            {
                Console.Write($"{node.val}\t");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
