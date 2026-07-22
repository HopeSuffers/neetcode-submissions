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

public class Codec {

    public string Serialize(TreeNode root)
    {
        var s = "";

        void dfs(TreeNode current)
        {
            if (current == null)
            {
                s += "N,";
                return;
            }

            s += current.val + ",";
            dfs(current.left);
            dfs(current.right);
        }

        dfs(root);
        return s.Substring(0, s.Length - 1);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data)
    {
        string[] values = data.Split(',');
        var index = 0;

        TreeNode DFS()
        {
            if (values[index] == "N")
            {
                index++;
                return null;
            }

            var node = new TreeNode(int.Parse(values[index]));
            index++;
            node.left = DFS();
            node.right = DFS();


            return node;
        }

        return DFS();
    }
}
