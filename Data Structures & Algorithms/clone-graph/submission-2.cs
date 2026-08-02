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
    public Node CloneGraph(Node node) {
        if (node == null)
            return null;

        var clones = new Dictionary<Node, Node>();

        return Dfs(node);

        Node Dfs(Node current) {
            if (clones.ContainsKey(current))
                return clones[current];

            var clone = new Node(current.val);
            clones[current] = clone;

            foreach (var currentNeighbor in current.neighbors) {
                clone.neighbors.Add(Dfs(currentNeighbor));
            }

            return clone;
        }
    }
}
