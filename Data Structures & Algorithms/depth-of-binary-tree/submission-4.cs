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
    public int MaxDepth(TreeNode root)
    {
        return dfs(root);
        
        int dfs(TreeNode current)
        {
            if (current == null)
                return 0;

            var left = MaxDepth(current.left);
            var right = MaxDepth(current.right);

            return Math.Max(left, right) + 1;
        }
    }
}
