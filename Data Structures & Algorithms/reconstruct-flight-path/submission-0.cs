public class Solution {
    public List<string> FindItinerary(List<List<string>> tickets) {
        var graph = new Dictionary<string, List<string>>();

        foreach (var ticket in tickets) {
            var from = ticket[0];
            var to = ticket[1];

            if (!graph.ContainsKey(from))
                graph[ticket[0]] = new List<string>();

            graph[ticket[0]].Add(to);
        }

        foreach (var destinations in graph.Values)
            destinations.Sort((a, b) => string.CompareOrdinal(b, a));

        var bucket = new List<string>();
        Dfs("JFK");
        bucket.Reverse();
        return bucket;

        void Dfs(string start) {
            while (graph.ContainsKey(start) && graph[start].Count > 0) {
                var distination = graph[start];

                string next = distination[^1];
                distination.RemoveAt(distination.Count - 1);
                Dfs(next);
            }

            bucket.Add(start);
        }
    }
}
