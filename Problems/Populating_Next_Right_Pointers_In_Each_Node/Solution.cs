using System;
using System.Collections.Generic;
using System.Text;

namespace Populating_Next_Right_Pointers_In_Each_Node
{
    using Common;

    public class Solution
    {
        public void Connect(TreeLinkNode root)
        {
            Connect(root, null);
        }

        public void Connect(TreeLinkNode node, TreeLinkNode parent)
        {
            if (node == null)
            {
                return;
            }
            if (parent == null)
            {
                node.next = null;
            }
            else if (node == parent.left)
            {
                node.next = parent.right;
            }
            else
            {
                node.next = parent.next?.left;
            }
            Connect(node.left, node);
            Connect(node.right, node);
        }
    }

    /* C++
    class Solution
    {
        public:
        void connect(TreeLinkNode* root)
        {
            helper(root, NULL);
        }

        void helper(TreeLinkNode* node, TreeLinkNode* parent)
        {
            if (node == NULL) return;
            if (parent == NULL) node->next = NULL;
            else if (node == parent->left) node->next = parent->right;
            else if (parent->next == NULL) node->next = NULL;
            else node->next = parent->next->left;
            helper(node->left, node);
            helper(node->right, node);
        }
    };
    */
}
