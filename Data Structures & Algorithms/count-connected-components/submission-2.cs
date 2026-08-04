public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var dic = new Dictionary<int, List<int>>();
        int counter = 0;

        for (int i = 0; i < n; i++) dic[i] = new List<int>();

        foreach (var edge in edges) {
            var node = edge[0];
            var currentEdge = edge[1];

            dic[node].Add(currentEdge);
            dic[currentEdge].Add(node);
        }

        var visited = new HashSet<int>();

        for (int i = 0; i < n; i++) {
            if (visited.Contains(i))
                continue;

            counter++;
            Dfs(i);
        }

        return counter;

        void Dfs(int node) {
            if (visited.Contains(node))
                return;

            visited.Add(node);

            foreach (var i in dic[node]) Dfs(i);
        }
    }
}