public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var min = int.MaxValue;
        var best = 0;

        foreach (var price in prices)
        {
            min = Math.Min(min, price);

            var current = price - min;
            best = Math.Max(current, best);
        }

        return best;
    }
}
