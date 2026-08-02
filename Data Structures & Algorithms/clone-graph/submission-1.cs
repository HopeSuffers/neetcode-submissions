/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        var clone = new Dictionary<Node, Node>();

        return Dfs(node);

        Node Dfs(Node current)
        {
            if (clone.ContainsKey(current))
                return clone[current];

            var copy = new Node(current.val);
            clone[current] = copy;

            foreach (var nodeNeighbor in current.neighbors)
            {
                copy.neighbors.Add(Dfs(nodeNeighbor));
            }

            return copy;
        }
    }
}
