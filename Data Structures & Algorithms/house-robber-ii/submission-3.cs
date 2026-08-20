public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        if (nums.Length <= 2)
            return nums.Max();

        return Math.Max(Robber(nums, 0, nums.Length - 2), Robber(nums, 1, nums.Length - 1));

        int Robber(int [] nums, int start, int end)
        {
            var rob1 = 0;
            var rob2 = 0;

            for (int i = start; i <= end; i++)
            {
                var tmp = Math.Max(rob1 + nums[i], rob2);
                rob1 = rob2;
                rob2 = tmp;
            }

            return rob2;
        }
    }
}