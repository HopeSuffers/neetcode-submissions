public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var list = new List<int>() { };
        var returnList = new List<int>();

        for (int i = 0; i < k; i++)
        {
            list.Add(nums[i]);
        }
       
        returnList.Add(list.Max());
        
        var left = 0;
        for (int right = k; right < nums.Length; right++)
        {
            left++;
            list.RemoveAt(0);
            list.Add(nums[right]);
            returnList.Add(list.Max());
        }
        
        return returnList.ToArray();
    }
}
