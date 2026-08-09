public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];

        return Math.Max(
            RobRange(nums, 0, nums.Length - 2),
            RobRange(nums, 1, nums.Length - 1)
        );
    }

    private int RobRange(int[] nums, int start, int end)
    {
        int prev2 = 0;
        int prev1 = 0;

        for (int i = start; i <= end; i++)
        {
            int current = Math.Max(
                prev1,       
                prev2 + nums[i] 
            );

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}