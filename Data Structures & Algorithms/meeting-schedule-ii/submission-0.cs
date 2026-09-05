/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
     public int MinMeetingRooms(List<Interval> intervals)
    {
        if (intervals.Count == 0)
            return 0;

        if (intervals.Count == 1)
            return 1;

        intervals.Sort((a,b ) => a.start.CompareTo(b.start));

        var queue = new PriorityQueue<int, int>();
        queue.Enqueue(intervals[0].start, intervals[0].end);

        var maxRooms = 1;

        for (var i = 1; i < intervals.Count; i++)
        {
            while (queue.Count > 0)
            {
                queue.TryDequeue(out int element1, out int element2 );

                if (intervals[i].start >= element2)
                    continue;

                queue.Enqueue(element1, element2);
                queue.Enqueue(intervals[i].start, intervals[i].end);
                maxRooms = Math.Max(maxRooms, queue.Count);
                break;
            }
        }

        return maxRooms;
    }
}
