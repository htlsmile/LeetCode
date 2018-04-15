using System;
using System.Text;

namespace Add_Two_Numbers
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            var l1 = GetList(2, 4, 3);
            Console.WriteLine(ShowList(l1));
            var l2 = GetList(5, 6, 4);
            Console.WriteLine(ShowList(l2));
            var l3 = solution.AddTwoNumbers(l1, l2);
            Console.WriteLine(ShowList(l3));
            Console.ReadKey(true);
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

        static string ShowList(ListNode list)
        {
            if (list == null)
            {
                return string.Empty;
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
                return sb.ToString();
            }
        }
    }
}
