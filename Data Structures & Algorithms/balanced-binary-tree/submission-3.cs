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
     public bool IsBalanced(TreeNode root)
    {
        return Dfs(root).IsBalanced;
    }

    private (bool IsBalanced, int Height) Dfs(TreeNode node)
    {
        if (node == null)
            return (true, 0);

        var left = Dfs(node.left);
        var right = Dfs(node.right);

        var isBalanced = 
        right.IsBalanced && 
        left.IsBalanced && 
        Math.Abs(left.Height - right.Height) <= 1;

        var height = Math.Max(left.Height, right.Height) + 1;

        return (isBalanced, height);
    }
}
