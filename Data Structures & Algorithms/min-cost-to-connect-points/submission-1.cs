public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        var n = points.Length;

        bool[] visited = new bool[n];
        var minDistance = new int[n];

        Array.Fill(minDistance, int.MaxValue);
        minDistance[0] = 0;

        int result = 0;

        for (int count = 0; count < n; count++) {
            int next = -1;

            for (int i = 0; i < n; i++) {
                if (visited[i])
                    continue;

                if (next == -1 || minDistance[i] < minDistance[next])
                    next = i;
            }

            visited[next] = true;
            result += minDistance[next];

            for (int i = 0; i < n; i++) {
                if (visited[i])
                    continue;

                var distance =
                    Math.Abs(points[next][0] - points[i][0]) + Math.Abs(points[next][1] - points[i][1]);

                minDistance[i] = Math.Min(minDistance[i], distance);
            }
        }

        return result;
    }
}
