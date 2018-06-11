using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Serialize_And_Deserialize_Binary_Tree
{
    public class Codec
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var list = new List<int?>();
            var queue = new Queue<TreeNode>();
            if (root != null)
            {
                queue.Enqueue(root);
            }
            while (queue.Count > 0)
            {
                var t = queue.Dequeue();
                list.Add(t?.val);
                if (t != null)
                {
                    queue.Enqueue(t.left);
                    queue.Enqueue(t.right);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append($"{(item.HasValue ? item.Value.ToString() : "null")},");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var array = data.Split(',');
            var list = new List<int?>();
            for (int i = 0; i < array.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(array[i]))
                {
                    continue;
                }
                else if (array[i] == "null")
                {
                    list.Add(null);
                }
                else
                {
                    list.Add(int.Parse(array[i]));
                }
            }
            if (list.Count == 0)
            {
                return null;
            }
            var result = new TreeNode(list[0].Value);
            list.RemoveAt(0);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(result);
            while (queue.Count > 0)
            {
                TreeNode t = queue.Dequeue();
                t.left = list[0].HasValue ? new TreeNode(list[0].Value) : null;
                if (t.left != null)
                {
                    queue.Enqueue(t.left);
                }
                list.RemoveAt(0);
                t.right = list[0].HasValue ? new TreeNode(list[0].Value) : null;
                if (t.right != null)
                {
                    queue.Enqueue(t.right);
                }
                list.RemoveAt(0);
            }
            return result;
        }
    }
}
