using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Common;

namespace Merge_K_Sorted_Lists
{

    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var result = new ListNode(int.MinValue);
            var node = result;
            var nodes = lists.ToList();
            while (nodes.Count > 0)
            {
                int index = -1;
                int min = int.MaxValue;
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i] == null)
                    {
                        nodes.RemoveAt(i);
                        i--;
                        continue;
                    }
                    if (nodes[i].val <= min)
                    {
                        index = i;
                        min = nodes[i].val;
                    }
                }
                if(index>-1)
                {
                    node.next = new ListNode(min);
                    node = node.next;
                    nodes[index] = nodes[index].next;
                }
            }
            return result.next;
        }
    }
}
