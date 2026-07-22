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
    public List<List<int>> LevelOrder(TreeNode root)
    {
        var list = new List<List<int>>();

        if (root == null)
            return list;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var length = queue.Count;
            var level = new List<int>();

            for (int i = 0; i < length; i++)
            {
                var node = queue.Dequeue();
                if (node == null) continue;

                level.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            if (level.Count > 0)
                list.Add(level);
        }

        return list;
    }
}
