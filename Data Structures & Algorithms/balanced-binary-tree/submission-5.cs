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
        return dfs(root).balance;
        
        (bool balance, int depth) dfs(TreeNode current)
        {
            if (current == null)
                return (true, 0);

            var left = dfs(current.left);
            var right = dfs(current.right);

            var depth = Math.Abs(left.depth - right.depth);
            var balance = left.balance && right.balance;
            var height = Math.Max(left.depth, right.depth) + 1;

            return (balance && depth <= 1, height);
        }
    }
}
