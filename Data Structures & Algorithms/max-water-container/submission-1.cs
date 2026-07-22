public class Solution {
    public int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        var bestWater = 0;
        
        while (left < right)
        {
            var maxHeight = Math.Min(heights[left], heights[right]);
            var length = right - left;
            var currentWater = maxHeight * length;

            bestWater = Math.Max(currentWater, bestWater);

            if (heights[left] < heights[right])
                left++;
            else right--;
        }

        return bestWater;
    }
}
