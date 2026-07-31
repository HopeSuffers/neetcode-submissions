public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var returnList = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int start) {
            if (current.Count == nums.Length) {
                returnList.Add(new List<int>(current));
                return;
            }

            for (int index = 0; index < nums.Length; index++) {
                if (current.Contains(nums[index]))
                    continue;

                current.Add(nums[index]);
                Dfs(index + 1);
                current.RemoveAt(current.Count - 1);
            }
        }
        Dfs(0);
        return returnList;
    }
}
