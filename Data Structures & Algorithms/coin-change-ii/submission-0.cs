public class Solution {
    public int Change(int amount, int[] coins) {
        var memo = new Dictionary<(int, int), int>();
        return Dfs(0, 0);

        int Dfs(int index, int currentAmount) {
            if (currentAmount == amount)
                return 1;

            if (currentAmount > amount || index >= coins.Length)
                return 0;

            if (memo.ContainsKey((index, currentAmount)))
                return memo[(index, currentAmount)];

            var take = Dfs(index, currentAmount + coins[index]);
            var skip = Dfs(index + 1, currentAmount);

            int result = take + skip;
            memo[(index, currentAmount)] = result;
            return result;
        }
    }
}
