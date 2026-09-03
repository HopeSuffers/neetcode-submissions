public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var total = 0;
        var tank = 0;
        var start = 0;

        for (int i = 0; i < cost.Length; i++)
        {
            var cur = gas[i] - cost[i];
            total += cur;
            tank += cur;

            if (tank < 0)
            {
                start = i + 1;
                tank = 0;
            }
        }

        return total >= 0 ? start : -1;
    }
}
