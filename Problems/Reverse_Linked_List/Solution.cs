using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }

        public ListNode ReverseList_Recursion(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode p = ReverseList_Recursion(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }
    }
}
