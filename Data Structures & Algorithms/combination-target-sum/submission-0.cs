public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        var listReturn = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index, int remaining)
        {
            if (remaining == 0)
            {
                listReturn.Add(new List<int>(current));
                return;
            }
            
            if (index >= nums.Length || remaining < 0)
                return;
            
            current.Add(nums[index]);
            Dfs(index, remaining - nums[index]);
            
            current.RemoveAt(current.Count -1);
            Dfs(index + 1, remaining);
        }
        
        Dfs(0, target);
        return listReturn;
    }
}
