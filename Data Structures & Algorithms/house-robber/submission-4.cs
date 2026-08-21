public class Solution {
    public int Rob(int[] nums) {
        var prev1 = 0;
        var prev2 = 0;

        for (int i = 0; i < nums.Length; i++) {
            var current = Math.Max(prev2 + nums[i], prev1);
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}