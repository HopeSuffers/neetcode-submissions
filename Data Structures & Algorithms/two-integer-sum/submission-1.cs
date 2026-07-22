
    
public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var searchedNumber = target - nums[i];

            if (dic.ContainsKey(nums[i]))
                return [dic[nums[i]], i];
            
            dic.Add(searchedNumber, i);
        }

        return Array.Empty<int>();
    }
}

