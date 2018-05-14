using System;
using System.Collections.Generic;
using System.Text;

namespace Odd_Even_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            var odd = head;
            var even = head?.next;
            var head2 = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            if (odd != null)
            {
                odd.next = head2;
            }
            return head;
        }
    }
}
