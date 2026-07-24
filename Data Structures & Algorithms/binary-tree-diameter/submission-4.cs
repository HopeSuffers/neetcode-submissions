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
        var diameter = 0;

        int dfs(TreeNode current)
        {
            if (current == null)
                return 0;

            var left = dfs(current.left);
            var right = dfs(current.right);

            if (current.left != null)
                left++;
            if (current.right != null)
                right++;
            
            diameter = Math.Max(diameter, left + right);

            return Math.Max(left, right);
        }

        dfs(root);
        return diameter;
    }
}
