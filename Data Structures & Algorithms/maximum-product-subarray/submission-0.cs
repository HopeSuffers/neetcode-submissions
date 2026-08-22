public class Solution {
    public int MaxProduct(int[] nums) {
        var result = nums.Max();

        var curMin = 1;
        var curMax = 1;

        foreach (var num in nums) {
            var tmp = curMax * num;
            curMax = Math.Max(Math.Max(curMax * num, curMin * num), num);
            curMin = Math.Min(Math.Min(tmp, curMin * num), num);
            result = Math.Max(curMax, result);
        }

        return result;
    }
}
