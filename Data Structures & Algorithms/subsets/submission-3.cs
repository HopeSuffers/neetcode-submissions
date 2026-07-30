public class Solution {
    public List<List<int>> Subsets(int[] nums)
    {
        var returnList = new List<List<int>>();
        var subset = new List<int>();

        void Dfs(int index)
        {
            if (index >= nums.Length)
            {
                returnList.Add(new List<int>(subset));
                return;
            }
            
            subset.Add(nums[index]);
            Dfs(index + 1);
            
            subset.RemoveAt(subset.Count - 1);
            Dfs(index + 1);
        }

        Dfs(0);
        return returnList;
    }
}
