public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length <= 2)
            return nums.Max();
            
        return Math.Max(Robber(0, nums.Length - 1), Robber(1, nums.Length));

        int Robber(int start, int end)
        {
            var prev1 = 0;
            var prev2 = 0;

            for (int i = start; i < end; i++)
            {
                var current = Math.Max(prev2 + nums[i], prev1);

                prev2 = prev1;
                prev1 = current;
            }

            return prev1;
        }
    }
}