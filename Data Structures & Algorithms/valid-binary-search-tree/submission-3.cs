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
    public bool IsValidBST(TreeNode root)
    {
        return Valid(root, null, null);
    }

    private bool Valid(TreeNode node, long? min, long? max)
    {
        if (node == null)
            return true;

        if (min.HasValue && node.val <= min)
            return false;

        if (max.HasValue && node.val >= max)
            return false;

        return Valid(node.left, min, node.val) && Valid(node.right, node.val, max);
    }
}
