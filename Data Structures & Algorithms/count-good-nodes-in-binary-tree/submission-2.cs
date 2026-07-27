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
    public int GoodNodes(TreeNode root)
    {
        if (root == null)
            return 0;
        
        var goodNodes = 0;
        dfs(root, root.val);
        return goodNodes;
        
        void dfs(TreeNode current, int maxValue)
        {
            if (current == null)
                return;

            dfs(current.left, Math.Max(current.val, maxValue));
            dfs(current.right, Math.Max(current.val, maxValue));

            if (current.val >= maxValue)
                goodNodes++;
        }
    }
}
