public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        var graph = new Dictionary<int, List<(int, int)>>();

        for (int node = 1; node <= n; node++)
            graph[node] = new List<(int, int)>();
        
        foreach (var time in times)
            graph[time[0]].Add((time[1], time[2]));
        
        var dijkstra = Dijkstra(graph, k);

        var max = int.MinValue;
        foreach (var i in dijkstra)
        {
            if (i.Value == int.MaxValue)
                return -1;

            max = Math.Max(max, i.Value);
        }

        return max;


        Dictionary<int, int> Dijkstra(Dictionary<int, List<(int neightor, int weight)>> graph, int start)
        {
            var distances = new Dictionary<int, int>();

            foreach (var node in graph.Keys)
                distances[node] = int.MaxValue;

            distances[start] = 0;

            var minHeap = new PriorityQueue<int, int>();
            minHeap.Enqueue(start, 0);

            while (minHeap.Count > 0)
            {
                minHeap.TryDequeue(out int node, out int distance);

                if (distances[node] < distance)
                    continue;

                foreach (var neighbor in graph[node])
                {
                    int newDistance = neighbor.weight + distance;

                    if (newDistance < distances[neighbor.neightor])
                    {
                        distances[neighbor.neightor] = newDistance;
                        minHeap.Enqueue(neighbor.neightor, newDistance);
                    }
                }
            }

            return distances;
        }
    }
}
