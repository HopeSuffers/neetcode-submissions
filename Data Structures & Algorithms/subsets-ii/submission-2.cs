public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        var returnList = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index)
        {
            if (index == nums.Length)
            {
                returnList.Add(new List<int>(current));
                return;
            }

            current.Add(nums[index]);
            Dfs(index + 1);
            current.RemoveAt(current.Count - 1);

            while (index + 1 < nums.Length && nums[index] == nums[index + 1])
            {
                index++;
            }

            Dfs(index + 1);
        }

        Dfs(0);
        return returnList;
    }
}
