using System;
using System.Linq;
using System.Linq.Expressions;

namespace Common
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BinaryTree
    {
        public static void PreorderTraversal(TreeNode node, Action<int> action = null)
        {
            if (node == null)
            {
                return;
            }
            if (action == null)
            {
                action = val => Console.Write($"{val} ");
            }
            action(node.val);
            PreorderTraversal(node.left, action);
            PreorderTraversal(node.right, action);
        }

        public static void InorderTraversal(TreeNode node, Action<int> action = null)
        {
            if (node == null)
            {
                return;
            }
            if (action == null)
            {
                action = val => Console.Write($"{val} ");
            }
            InorderTraversal(node.left, action);
            action(node.val);
            InorderTraversal(node.right, action);
        }

        public static void PostorderTraversal(TreeNode node, Action<int> action = null)
        {
            if (node == null)
            {
                return;
            }
            if (action == null)
            {
                action = val => Console.Write($"{val} ");
            }
            PostorderTraversal(node.left, action);
            PostorderTraversal(node.right, action);
            action(node.val);
        }

        public static TreeNode GetTestTree()
        {
            var tree = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            return tree;
        }

        public static TreeNode GetTestSearchTree()
        {
            var tree = new TreeNode(12)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(9)
                },
                right = new TreeNode(18)
                {
                    left = new TreeNode(15)
                    {
                        right = new TreeNode(17)
                        {
                            left = new TreeNode(16)
                        }
                    },
                    right = new TreeNode(19)
                }
            };
            return tree;
        }
    }
}
