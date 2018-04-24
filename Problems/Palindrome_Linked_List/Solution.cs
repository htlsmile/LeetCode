using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            var slow = head;
            var fast = head;
            Stack<int> stack = new Stack<int>();
            while (fast != null && fast.next != null)
            {
                stack.Push(slow.val);
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast != null)
            {
                slow = slow.next;
            }
            while (slow != null)
            {
                if (stack.Count == 0 || stack.Pop() != slow.val)
                {
                    return false;
                }
                slow = slow.next;
            }
            return true;
        }
    }
}
