public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var dic = new Dictionary<int, List<int>>();
        var returnArray = new int[] {};

        for (int i = 0; i < edges.Length + 1; i++) dic[i] = new List<int>();

        foreach (var edge in edges) {
            var node = edge[0];
            var currentEdge = edge[1];

            var visited = new HashSet<int>();

            if (HasPath(node, currentEdge, visited))
                return edge;

            dic[node].Add(currentEdge);
            dic[currentEdge].Add(node);
        }

        return [];

        bool HasPath(int current, int target, HashSet<int> visited) {
            if (current == target)
                return true;

            if (!visited.Add(current))
                return false;

            foreach (var neighbor in dic[current]) {
                if (HasPath(neighbor, target, visited))
                    return true;
            }

            return false;
        }
    }
}
