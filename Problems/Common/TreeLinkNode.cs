using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class TreeLinkNode
    {
        public int val;
        public TreeLinkNode left;
        public TreeLinkNode right;
        public TreeLinkNode next;
        public TreeLinkNode(int x)
        {
            val = x;
        }

        public static TreeLinkNode GetPerfectTree()
        {
            return new TreeLinkNode(1)
            {
                left = new TreeLinkNode(2)
                {
                    left = new TreeLinkNode(4),
                    right = new TreeLinkNode(5)
                },
                right = new TreeLinkNode(3)
                {
                    left = new TreeLinkNode(6),
                    right = new TreeLinkNode(7)
                }
            };
        }

        public static void ShowTree(TreeLinkNode node, Action<TreeLinkNode> action = null)
        {
            if (node == null)
            {
                return;
            }
            if (action == null)
            {
                action = n => Console.WriteLine($"this.val:{n?.val}\tnext.val:{n?.next?.val ?? 0}"); ;
            }
            action(node);
            ShowTree(node.left);
            ShowTree(node.right);
        }
    }

}
