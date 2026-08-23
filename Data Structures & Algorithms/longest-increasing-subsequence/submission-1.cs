public class Solution {
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length + 1];

        for (int i = nums.Length; i >= 0; i--) {
            dp[i] = 1;

            for (int j = i; j < nums.Length; j++) {
                if (nums[j] <= nums[i])
                    continue;

                dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
        }

        return dp.Max();
    }
}
