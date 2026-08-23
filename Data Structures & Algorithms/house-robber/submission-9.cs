public class Solution {
    public int Rob(int[] nums)
    {
        var next = 0;
        var nextNext = 0;
        for (int i = nums.Length-1; i >= 0; i--)
        {
            nums[i] = Math.Max(next, nums[i] + nextNext);
            nextNext = next;
            next = nums[i];
        }

        return next;
    }
}