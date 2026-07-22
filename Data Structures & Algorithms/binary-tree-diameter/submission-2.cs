/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int DiameterOfBinaryTree(TreeNode root)
    {
        var maxdepth = 0;

        SubtreeDepth(root);

        return maxdepth;

        int SubtreeDepth(TreeNode current)
        {
            if (current == null)
                return 0;

            var left = SubtreeDepth(current.left);
            var right = SubtreeDepth(current.right);

            maxdepth = Math.Max(maxdepth, right + left);
            return Math.Max(left, right) + 1;
        }
    }
}
