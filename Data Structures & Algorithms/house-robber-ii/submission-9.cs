public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length < 2)
            return nums.Max();

        return Math.Max(Robber(0, nums.Length - 1), Robber(1, nums.Length));

        int Robber(int start, int end) {
            var next = 0;
            var nextNext = 0;

            for (int i = start; i < end; i++) {
                var current = Math.Max(nextNext + nums[i], next);
                nextNext = next;
                next = current;
            }

            return next;
        }
    }
}