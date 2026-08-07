public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var queue = new PriorityQueue<int[], double>();
        var list = new List<int[]>();

        foreach (var point in points) {
            var distance = Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
            queue.Enqueue(point, distance);
        }

        for (int i = 0; i < k; i++) list.Add(queue.Dequeue());

        return list.ToArray();
    }
}