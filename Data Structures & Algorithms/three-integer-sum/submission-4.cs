public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> listReturn = new List<List<int>>();
        
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    listReturn.Add(new List<int>() {nums[i], nums[left], nums[right] });

                    left++;
                    right--;
                    
                    while (left < right && nums[left] == nums[left - 1])
                        left++;

                    while (left < right && nums[right] == nums[right + 1])
                        right--;

                    continue;
                }

                if (sum < 0)
                    left++;
                else right--;
            }
        }

        return listReturn;
    }
}