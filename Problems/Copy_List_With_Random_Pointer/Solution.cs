using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Copy_List_With_Random_Pointer
{
    public class Solution
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            RandomListNode iter = head, next;
            while (iter != null)
            {
                next = iter.next;
                var t = new RandomListNode(iter.label);
                iter.next = t;
                t.next = next;
                iter = next;
            }
            iter = head;
            while (iter != null)
            {
                if (iter.random != null)
                {
                    iter.next.random = iter.random.next;
                }
                iter = iter.next.next;
            }
            iter = head;
            var pseudoHead = new RandomListNode(0);
            RandomListNode copy, copyIter = pseudoHead;
            while (iter != null)
            {
                next = iter.next.next;
                copy = iter.next;
                copyIter.next = copy;
                copyIter = copy;
                iter.next = next;
                iter = next;
            }
            return pseudoHead.next;
        }
    }
}
