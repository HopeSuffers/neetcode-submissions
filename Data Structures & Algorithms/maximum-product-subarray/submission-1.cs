public class Solution {
    public int MaxProduct(int[] nums) {
        var max = 1;
        var min = 1;
        int result = nums.Max();

        foreach (var num in nums) {
            var tmp = max * num;
            max = Math.Max(Math.Max(max * num, min * num), num);
            min = Math.Min(Math.Min(min * num, tmp), num);
            result = Math.Max(result, max);
        }

        return result;
    }
}
