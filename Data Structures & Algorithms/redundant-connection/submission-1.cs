public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var dic = new Dictionary<int, List<int>>();

        for (int i = 1; i <= edges.Length; i++) {
            dic[i] = new List<int>();
        }

        foreach (var edge in edges) {
            var first = edge[0];
            var second = edge[1];

            var visited = new HashSet<int>();

            // call has Path
            if (HasPath(first, second, visited))
                return edge;

            dic[first].Add(second);
            dic[second].Add(first);
        }

        return Array.Empty<int>();

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