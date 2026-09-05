public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var sortedQueries =
            queries.Select((value, index) => (value, index)).OrderBy(x => x.value).ToArray();

        var result = new int[queries.Length];

        // element = interval end
        // priority = interval length
        var minHeap = new PriorityQueue<int, int>();

        int i = 0;

        foreach (var query in sortedQueries) {
            int value = query.value;
            int originalIndex = query.index;

            // Add every interval that could contain this query.
            while (i < intervals.Length && intervals[i][0] <= value) {
                int start = intervals[i][0];
                int end = intervals[i][1];
                int length = end - start + 1;

                minHeap.Enqueue(end, length);

                i++;
            }

            // Remove intervals that end before the query.
            while (minHeap.Count > 0 && minHeap.Peek() < value) {
                minHeap.Dequeue();
            }

            // The heap top is now the smallest valid interval.
            if (minHeap.Count > 0) {
                minHeap.TryPeek(out _, out int length);
                result[originalIndex] = length;
            } else {
                result[originalIndex] = -1;
            }
        }

        return result;
    }
}
