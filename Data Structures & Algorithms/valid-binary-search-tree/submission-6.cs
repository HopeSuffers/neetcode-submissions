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

public class Solution 
{
     public bool IsValidBST(TreeNode root)
    {
        return Valid(root, null, null);

        bool Valid(TreeNode current, int? min, int? max)
        {
            if (current == null)
                return true;

            if (min.HasValue && current.val <= min)
                return false;

            if (max.HasValue && current.val >= max)
                return false;

            return Valid(current.left, min, current.val) && Valid(current.right, current.val, max);
        }
    }
}
