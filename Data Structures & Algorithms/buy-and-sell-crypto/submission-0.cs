public class Solution {
    public int MaxProfit(int[] prices)
    {
        var lowestPrice = int.MaxValue;
        var bestPrice = 0;

        foreach (var price in prices)
        {
            lowestPrice = Math.Min(price, lowestPrice);

            var currentPrice = price - lowestPrice;
            bestPrice = Math.Max(bestPrice, currentPrice);
        }

        return bestPrice;
    }
}
