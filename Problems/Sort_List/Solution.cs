using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Sort_List
{
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }
            ListNode prev = null, slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;
            var l1 = SortList(head);
            var l2 = SortList(slow);
            return Merge(l1, l2);
        }

        ListNode Merge(ListNode l1, ListNode l2)
        {
            ListNode r = new ListNode(0), p = r;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    p.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    p.next = l2;
                    l2 = l2.next;
                }
                p = p.next;
            }
            p.next = l1 ?? l2;
            return r.next;
        }
    }
}
