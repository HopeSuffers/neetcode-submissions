public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        var result = new List<List<int>> { };
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var test = nums[i] + nums[left] + nums[right];

                if (test == 0)
                {
                    result.Add([
                        nums[i],
                        nums[left],
                        nums[right]
                    ]);
                    
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                        left++;
                    while (left < right && nums[right] == nums[right + 1])
                        right--; 
                    
                    continue;
                }

                if (test < 0) left++;
                else right--;
            }
        }

        return result;
    }
}