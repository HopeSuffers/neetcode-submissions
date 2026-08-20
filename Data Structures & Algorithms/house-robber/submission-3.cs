public class Solution
{
    public int Rob(int[] nums)
    {
        var rob1 = 0;
        var rob2 = 0;

        foreach (var num in nums)
        {
            var tmp = Math.Max(num + rob1, rob2);
            rob1 = rob2;
            rob2 = tmp;
        }

        return rob2;
    }
}