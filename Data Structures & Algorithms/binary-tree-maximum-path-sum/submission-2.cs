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
    public int MaxPathSum(TreeNode root)
    {
        int max = int.MinValue;
        
        int CheckMaxPath(TreeNode current)
        {
            if (current == null)
                return 0;

            var left = CheckMaxPath(current.left);
            var right = CheckMaxPath(current.right);

            var localHeigest = int.MinValue;
            localHeigest = Math.Max(localHeigest, left + current.val);
            localHeigest = Math.Max(localHeigest, right + current.val);
            
            max = Math.Max(localHeigest, max);
            max = Math.Max(left + right + current.val, max);

            return localHeigest > 0 ? localHeigest : 0;
        }

        CheckMaxPath(root);

        return max;
    }
}
