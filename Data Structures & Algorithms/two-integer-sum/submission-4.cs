

public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            
            var missing = target - nums[i];
            if (dic.ContainsKey(missing))
            {
                return new[] { dic[missing], i };
            }
            
            dic.Add(nums[i], i);
        }

        return [];
    }
}
