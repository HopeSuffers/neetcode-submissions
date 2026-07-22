public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var see = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if (see.ContainsKey(needed))
                return [see[needed], i];

            see[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
