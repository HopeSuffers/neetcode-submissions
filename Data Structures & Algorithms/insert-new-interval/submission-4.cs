public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
            return new[] { newInterval };

        var result = new List<int[]>();

        var start = newInterval[0];
        var end = newInterval[1];
        var i = 0;

        // Insert is bigger. We write the current interval value
        while (i < intervals.Length && newInterval[0] > intervals[i][1])
        {
            result.Add(intervals[i]);
            i++;
        }

        // intervall is bigger. we write newList then current interval
        while (i < intervals.Length && intervals[i][0] <= end)
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i++;
        }

        result.Add([start, end]);

        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}
