public class Solution {
     public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var returnList = new List<int[]>();
        int i = 0;
        var start = newInterval[0];
        var end = newInterval[1];

        while (i < intervals.Length && intervals[i][1] < start)
        {
            returnList.Add(intervals[i]);
            i++;
        }

        while (i < intervals.Length && end >= intervals[i][0])
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i++;
        }

        returnList.Add([start, end]);

        while (i < intervals.Length)
        {
           returnList.Add(intervals[i]);
           i++;
        }

        return returnList.ToArray();
    }
}
