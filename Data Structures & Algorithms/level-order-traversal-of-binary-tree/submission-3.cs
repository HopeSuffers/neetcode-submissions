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
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var level = new List<int>();
            var loops = queue.Count;

            for (int i = 0; i < loops; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.val);
                
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            
            if (level.Count > 0)
                list.Add(level);
        }

        return list;
    }
}
