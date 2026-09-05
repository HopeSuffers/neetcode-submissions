public class Solution {
    public int EraseOverlapIntervals(int[][] intervals)
    {
        var counter = 0;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var currentEnd = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] >= currentEnd)
            {
                currentEnd = intervals[i][1];
                continue;
            }

            currentEnd = Math.Min(currentEnd, intervals[i][1]);
            counter++;
        }

        return counter;
    }
}
