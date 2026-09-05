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
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals.Count < 2)
                return true;
                
        intervals.Sort((a, b) => a.start.CompareTo(b.start));
        var currentEnd = intervals[0].end;

        for (int i = 1; i < intervals.Count; i++) {
            if (currentEnd > intervals[i].start)
                return false;

            currentEnd = Math.Max(currentEnd, intervals[i].end);
        }

        return true;
    }
}
