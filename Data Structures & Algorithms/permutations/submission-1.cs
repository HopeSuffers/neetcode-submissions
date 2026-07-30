public class Solution {
    public List<List<int>> Permute(int[] nums)
    {
        var returnList = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index)
        {
            if (current.Count == nums.Length)
            {
                returnList.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (current.Contains(nums[i]))
                    continue;
                
                current.Add(nums[i]);
                Dfs(i);
                current.RemoveAt(current.Count-1);
            }
        }
        
        Dfs(0);
        return returnList;
    }
}
