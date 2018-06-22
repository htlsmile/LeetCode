using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode GetListNode(params int[] nums)
        {
            var root = new ListNode(0);
            var node = root;
            for (int i = 0; i < nums.Length; i++)
            {
                node.next = new ListNode(nums[i]);
                node = node.next;
            }
            return root.next;
        }

        public static void ShowListNode(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
