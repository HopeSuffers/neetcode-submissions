public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var next = 0;
        var nextNext = 0;

        for (int i = cost.Length - 1; i >= 0; i--) {
            cost[i] = Math.Min(next + cost[i], nextNext + cost[i]);
            nextNext = next;
            next = cost[i];
        }

        return Math.Min(cost[0], cost[1]);
    }
}