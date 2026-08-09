public class Solution
{
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        if (n == 0)
            return 0;
        if (n == 1)
            return nums[0];

        var prev2 = nums[0];
        var prev1 = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            var current = Math.Max(prev2 + nums[i], prev1);
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}