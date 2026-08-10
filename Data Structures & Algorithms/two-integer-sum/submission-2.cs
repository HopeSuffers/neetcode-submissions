
    
public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var needed = target - nums[i];

            if (dic.ContainsKey(needed))
            {
                var one = dic[needed];
                return new[] { one, i };
            }
            
            dic.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}

