public class Solution {
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length < 2)
            return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var returnList = new List<int[]>();
        int i = 0;

        while (i < intervals.Length)
        {
            if (i == intervals.Length - 1)
            {
                returnList.Add(intervals[i]);
                i++;
            }

            while (i < intervals.Length - 1 && intervals[i][1] < intervals[i + 1][0])
            {
                returnList.Add(intervals[i]);
                i++;
            }

            // new int[] { 1, 3 },
            // new int[] { 2, 6 },
            // new int[] { 8, 10 },
            // new int[] { 15, 18 }

            if (i < intervals.Length - 1 && intervals[i][1] >= intervals[i + 1][0])
            {
                int min = Math.Min(intervals[i][0], intervals[i + 1][0]);
                int max = Math.Max(intervals[i][1], intervals[i + 1][1]);
                while (i < intervals.Length - 1 && max >= intervals[i+1][0])
                {
                    min = Math.Min(min, intervals[i + 1][0]);
                    max = Math.Max(max, intervals[i + 1][1]);
                    i++;
                }

                returnList.Add([min, max]);
                i++;
            }
        }

        return returnList.ToArray();
    }
}
