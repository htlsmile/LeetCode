﻿using System;

namespace Odd_Even_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = GetLinkedList();
            Test(head);
            Test(null);
            Console.ReadKey(true);
        }

        static void Test(ListNode head)
        {
            var solution = new Solution();
            var result = solution.OddEvenList(head);
            ShowLinkedList(head);
            Console.WriteLine(result);
        }

        static ListNode GetLinkedList(int n = 10)
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
