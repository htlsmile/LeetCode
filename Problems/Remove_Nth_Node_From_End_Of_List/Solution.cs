using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Nth_Node_From_End_Of_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(0);
            dummy.next = head;
            var p = dummy;
            var q = dummy;
            for (int i = 0; i <= n; i++)
            {
                q = q.next;
            }
            while (q != null)
            {
                p = p.next;
                q = q.next;
            }
            p.next = p.next.next;
            return dummy.next;
        }
    }
}
