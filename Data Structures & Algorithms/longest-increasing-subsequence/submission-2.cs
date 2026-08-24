public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums.Length < 2)
            return 1;

        var dp = new int[nums.Length];
        Array.Fill(dp, 1);

        for (int i = nums.Length - 1; i >= 0; i--) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] < nums[j])
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
        }

        return dp.Max();
    }
}
