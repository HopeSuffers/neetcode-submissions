public class Solution {
    public int MissingNumber(int[] nums)
    {
        return nums.Length + nums.Select((t, i) => i - t).Sum();
    }
}
