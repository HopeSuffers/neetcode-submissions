public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<List<int>> { };

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var diff = nums[i] + nums[left] + nums[right];

                if (diff == 0)
                {
                    result.Add(new List<int>
                    {
                        nums[i],
                        nums[left],
                        nums[right]
                    });

                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                        left++;
                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }
                else if (diff < 0) left++;
                else right--;
            }
        }

        return result;
    }
}