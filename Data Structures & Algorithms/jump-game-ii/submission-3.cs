public class Solution {
    public int Jump(int[] nums)
    {
        if (nums.Length <= 1)
            return 0;

        var furthest = 0;
        var currentEnd = 0;
        var jumps = 0;

        for (int i = 0; i < nums.Length-1; i++)
        {
            furthest = Math.Max(furthest, nums[i] + i);

            if (i == currentEnd)
            {
                currentEnd = furthest;
                jumps++;
            }
        }

        return jumps;
    }
}
