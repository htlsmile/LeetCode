using System;

namespace Intersection_Of_Two_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = GetLinkedListC();
            Test(GetLinkedListA(c), GetLinkedListB(c));
            Console.ReadKey(true);
        }

        static void Test(ListNode headA, ListNode headB)
        {
            var solution = new Solution();
            var result = solution.GetIntersectionNode(headA, headB);
            Console.WriteLine(result?.val);
        }

        static ListNode GetLinkedListA(ListNode c)
        {
            return new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = c
                }
            };
        }

        static ListNode GetLinkedListB(ListNode c)
        {
            return new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = c
                    }
                }
            };
        }

        static ListNode GetLinkedListC()
        {
            return new ListNode(7)
            {
                next = new ListNode(8)
            };
        }
    }
}
