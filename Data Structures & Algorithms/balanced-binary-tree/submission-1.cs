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
        if (root == null)
            return true;
        
        int HeightTree(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = HeightTree(root.left);
            var right = HeightTree(root.right);

            return Math.Max(left, right) + 1;
        }

        var leftRoot = HeightTree(root.left);
        var rightRoot = HeightTree(root.right);

        return Math.Abs(leftRoot - rightRoot) <= 1 && IsBalanced(root.left)
        && IsBalanced(root.right);;
    }
}
