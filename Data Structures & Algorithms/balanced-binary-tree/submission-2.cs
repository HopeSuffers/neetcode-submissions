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

    private (bool IsBalanced, int Heigt) Dfs(TreeNode node)
    {
        if (node == null) 
            return (true, 0);

        var left = Dfs(node.left);
        var right = Dfs(node.right);

        bool balanced = left.IsBalanced && right.IsBalanced && Math.Abs(left.Heigt - right.Heigt) <= 1;

        int height = 1 + Math.Max(left.Heigt, right.Heigt);
        return (balanced, height);
    }
}
