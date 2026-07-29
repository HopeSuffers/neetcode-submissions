public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var returnList = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index) {
            if (index >= nums.Length) {
                returnList.Add(new List<int>(current));
                return;
            }

            current.Add(nums[index]);
            Dfs(index + 1);

            current.RemoveAt(current.Count - 1);
            Dfs(index + 1);
        }

        Dfs(0);
        return returnList;
    }
}
