public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        var memo = new Dictionary<(int, int), int>();
        return Dfs(0, 0);

        int Dfs(int index, int difference) {
            if (index == nums.Length)
                return difference == target ? 1 : 0;

            if (memo.ContainsKey((index, difference)))
                return memo[(index, difference)];

            var minus = Dfs(index + 1, difference - nums[index]);
            var plus = Dfs(index + 1, difference + nums[index]);

            memo.Add((index, difference), minus + plus);
            return minus + plus;
        }
    }
}
