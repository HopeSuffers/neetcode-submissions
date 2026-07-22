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

        return findGoodNotes(root, root.val) + 1;
    }

    private int findGoodNotes(TreeNode current, int heighstSeen)
    {
        if (current == null)
            return 0;

        int count = 0;

        var currentLeft = int.MinValue;
        if (current.left != null)
        {
            currentLeft = current.left.val;
            if (currentLeft >= heighstSeen)
                count++;
        }

        var currentRight = int.MinValue;
        if (current.right != null)
        {
            currentRight = current.right.val;
            if (currentRight >= heighstSeen)
                count++;
        }

        var heighestLeft = Math.Max(heighstSeen, currentLeft);
        var heighestRight = Math.Max(heighstSeen, currentRight);

        return findGoodNotes(current.left, heighestLeft) + findGoodNotes(current.right, heighestRight) + count;

    }
}
