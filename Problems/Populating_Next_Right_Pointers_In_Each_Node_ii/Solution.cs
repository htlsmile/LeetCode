using System;
using System.Collections.Generic;
using System.Text;

namespace Populating_Next_Right_Pointers_In_Each_Node_ii
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
            while (parent != null && node.next == null)
            {
                if (node == parent.left)
                {
                    node.next = parent.right;
                }
                parent = parent.next;
                node.next = node.next ?? parent?.left ?? parent?.right;
            }
            Connect(node.right, node);
            Connect(node.left, node);
        }
    }

    /* C++
class Solution {
public:
    void connect(TreeLinkNode *root) {
        helper(root,NULL);
    }
    
    void helper(TreeLinkNode *node,TreeLinkNode *parent){
        if(node==NULL)return;
        if(parent==NULL)node->next=NULL;
        while(parent!=NULL&&node->next==NULL){
            if(node==parent->left){
                node->next=parent->right;
            }
            parent=parent->next;
            if(parent!=NULL){
                if(node->next==NULL){
                    node->next=parent->left;
                }
                if(node->next==NULL){
                    node->next=parent->right;
                }
            }
        }
        helper(node->right,node);
        helper(node->left,node);
    }
};
    */
}
