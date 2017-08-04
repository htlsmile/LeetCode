using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> nums = new List<int>();
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int num = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);
                nums.Add((num + carry) % 10);
                carry = (num + carry) / 10;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (carry > 0)
            {
                nums.Add(carry);
            }
            ListNode lastNode = null;
            ListNode currentNode = null;
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                currentNode = new ListNode(nums[i]);
                currentNode.next = lastNode;
                lastNode = currentNode;
            }
            return currentNode;
        }
    }
}
