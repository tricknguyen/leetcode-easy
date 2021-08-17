using System;
using System.Collections.Generic;
using System.Text;

namespace solution_leetcode
{
    public class MaximumDepthOfBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int heightleft = MaxDepth(root.left);
                int heightright = MaxDepth(root.right);
                if (heightleft < heightright)
                {
                    return heightright + 1;
                }
                else
                {
                    return heightleft + 1;
                }
            }
        }
    }
}
