public class Solution {
    public int MaxProfit(int[] prices) {
        var memo = new Dictionary<(int, bool), int>();
        return Dfs(0, true);

        int Dfs(int day, bool buying) {
            if (day >= prices.Length)
                return 0;

            if (memo.ContainsKey((day, buying)))
                return memo[(day, buying)];

            var cooldown = Dfs(day + 1, buying);
            int result;

            if (buying) {
                int buy = Dfs(day + 1, false) - prices[day];
                result = Math.Max(buy, cooldown);
            } else {
                int sell = Dfs(day + 2, true) + prices[day];
                result = Math.Max(sell, cooldown);
            }

            memo[(day, buying)] = result;
            return result;
        }
    }
}
