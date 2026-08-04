public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        var dic = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++) dic[i] = new List<int>();

        foreach (var edge in edges) {
            var node = edge[0];
            var currentEdge = edge[1];
            dic[node].Add(currentEdge);
            dic[currentEdge].Add(node);
        }

        var visited = new HashSet<int>();

        if (Dfs(0, -1))
            return false;

        return visited.Count == n;

        bool Dfs(int node, int parent) {
            if (visited.Contains(node))
                return true;

            visited.Add(node);

            foreach (int neighbor in dic[node]) {
                if (neighbor == parent)
                    continue;

                if (Dfs(neighbor, node))
                    return true;
            }

            return false;
        }
    }
}