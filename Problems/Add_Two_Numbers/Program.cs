using System;
using System.Text;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = GetList(2, 4, 3);
            var l2 = GetList(5, 6, 4);
            Test(l1, l2);
            Console.ReadKey(true);
        }

        static void Test(ListNode l1, ListNode l2)
        {
            var solution = new Solution();
            var result = solution.AddTwoNumbers(l1, l2);
            ShowList(result);
        }

        static ListNode GetList(params int[] nums)
        {
            if (nums.Length < 1)
            {
                return null;
            }
            var list = new ListNode(nums[0]);
            var p = list;
            for (int i = 1; i < nums.Length; i++)
            {
                p.next = new ListNode(nums[i]);
                p = p.next;
            }
            return list;
        }

        static void ShowList(ListNode list)
        {
            if (list == null)
            {
                Console.WriteLine();
            }
            else
            {
                var node = list;
                StringBuilder sb = new StringBuilder();
                sb.Append(node.val);
                node = node.next;
                while (node != null)
                {
                    sb.Append($" -> {node.val}");
                    node = node.next;
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
