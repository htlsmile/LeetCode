using System;

namespace Remove_Nth_Node_From_End_Of_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = GetLinkedList();
            Test(head, 2);
            Console.ReadKey(true);
        }

        static void Test(ListNode head, int n)
        {
            var solution = new Solution();
            var newHead = solution.RemoveNthFromEnd(head, n);
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
