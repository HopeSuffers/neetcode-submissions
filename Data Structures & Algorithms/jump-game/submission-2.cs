public class Solution {
    public bool CanJump(int[] nums)
    {
        if (nums.Length == 1)
            return true;

        var best = 0;

        for (int i = 0; i < nums.Length-1; i++)
        {
            if (i > best)
                return false;

            best = Math.Max(best, nums[i] + i);
            
            if (best >= nums.Length-1)
                return true;
        }

        return false;
    }
}
