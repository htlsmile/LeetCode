using System;
using System.Collections.Generic;
using System.Text;

namespace Merge_Two_Sorted_Lists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var cur = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            if (l1 == null)
            {
                cur.next = l2;
            }
            else if (l2 == null)
            {
                cur.next = l1;
            }
            return head.next;
        }
    }
}
