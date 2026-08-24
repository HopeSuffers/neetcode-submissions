public class Solution {
    public bool CanPartition(int[] nums)
    {
        var total = nums.Sum();

        if (total % 2 == 1)
            return false;

        var target = total / 2;
        var dp = new bool[target + 1];
        dp[0] = true;

        foreach (var num in nums)
        {
            for (int sum = target; sum >= num; sum--)
            {
                dp[sum] = dp[sum] || dp[sum - num];
            }
        }

        return dp[target];
    }
}