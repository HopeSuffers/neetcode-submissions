public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var minValue = int.MaxValue;
        var maxValue = 0;

        foreach (var price in prices)
        {
            minValue = Math.Min(minValue, price);

            var currentPrice = price - minValue;
            maxValue = Math.Max(maxValue, currentPrice);
        }

        return maxValue;
    } 
}
