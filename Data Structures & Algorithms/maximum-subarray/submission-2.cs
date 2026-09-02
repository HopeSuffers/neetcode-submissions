public class Solution {
    public int MaxSubArray(int[] nums)
    {
        var current = nums[0];
        var best = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            current = Math.Max(nums[i], current + nums[i]);
            best = Math.Max(best, current);
        }

        return best;
    }
}
