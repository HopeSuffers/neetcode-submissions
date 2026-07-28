public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        var maxHeap = new PriorityQueue<int[], double>();
        var list = new List<int[]>();

        foreach (var point in points)
        {
            var length = Math.Sqrt(point[0] * point[0] + point[1] * point[1]);
            maxHeap.Enqueue(new[] { point[0], point[1]}, length);
        }

        for (int i = 0; i < k; i++)
        {
            list.Add(maxHeap.Dequeue());
        }

        return list.ToArray();
    }
}