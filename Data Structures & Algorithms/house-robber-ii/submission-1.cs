public class Solution
{
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        if (n == 0)
            return 0;
        if (n <= 2)
            return nums.Max();

        var numsList = nums.ToList();

        var noStart = new List<int>(numsList);
        noStart.RemoveAt(0);
        var firstRun = Roby(noStart);

        var noEnd = new List<int>(numsList);
        noEnd.RemoveAt(noEnd.Count-1);
        var secondRun = Roby(noEnd);

        return Math.Max(firstRun, secondRun);
    }

    public int Roby(List<int> nums)
    {
        var n = nums.Count;
        if (n == 0)
            return 0;
        if (n <= 2)
            return nums.Max();

        var prev2 = nums[0];
        var prev1 = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Count; i++)
        {
            var current = Math.Max(prev2 + nums[i], prev1);
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}