public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var dicFlights = new Dictionary<int, List<(int, int)>>();
        var memo = new Dictionary<(int city, int flightsLeft), int>();

        foreach (var flight in flights)
        {
            if (!dicFlights.ContainsKey(flight[0]))
                dicFlights[flight[0]] = new List<(int, int)>();

            dicFlights[flight[0]].Add((flight[1], flight[2]));
        }

        var result = Dfs(src, k + 1);
        return result == int.MaxValue ? -1 : result;

        int Dfs(int city, int flightsLeft)
        {
            if (city == dst)
                return 0;

            if (flightsLeft == 0)
                return int.MaxValue;

            if (memo.ContainsKey((city, flightsLeft)))
                return memo[(city, flightsLeft)];

            if (!dicFlights.ContainsKey(city))
                return int.MaxValue;

            int result = int.MaxValue;

            foreach (var valueTuple in dicFlights[city])
            {
                var remainingCost = Dfs(valueTuple.Item1, flightsLeft - 1);

                if (remainingCost == int.MaxValue)
                    continue;

                var totalCost = valueTuple.Item2 + remainingCost;

                result = Math.Min(result, totalCost);
            }

            memo[(city, flightsLeft)] = result;
            return result;
        }
    }
}
