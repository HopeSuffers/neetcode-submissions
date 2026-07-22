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
    public int KthSmallest(TreeNode root, int k)
    {
        var list = new List<int>();
        dfs(root);

        void dfs(TreeNode current)
        {
            if (current == null)
                return;

            list.Add(current.val);
            dfs(current.left);
            dfs(current.right);
        }
        
        list.Sort();
        return list[k - 1];
    }
}
