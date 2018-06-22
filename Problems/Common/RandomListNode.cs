using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { label = x; }

        public static RandomListNode GetRandomListNode()
        {
            var n1 = new RandomListNode(1);
            var n2 = new RandomListNode(2);
            var n3 = new RandomListNode(3);
            var n4 = new RandomListNode(4);
            var n5 = new RandomListNode(5);
            n1.next = n2; n1.random = n3;
            n2.next = n3; n2.random = n1;
            n3.next = n4; n3.random = n5;
            n4.next = n5; n4.random = n2;
            n5.next = null; n5.random = n4;
            return n1;
        }

        public static void ShowRandomListNode(RandomListNode node)
        {
            while (node != null)
            {
                Console.WriteLine($"val:{node.label}\tnext:{node.next?.label}\trandom:{node.random?.label}");
                node = node.next;
            }
        }
    }

}
