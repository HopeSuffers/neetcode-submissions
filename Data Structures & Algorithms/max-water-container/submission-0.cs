public class Solution {
    public int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        var bestScore = 0;
        
        while (left < right)
        {
            var score = (right - left) * Math.Min(heights[left], heights[right]);
            bestScore = Math.Max(score, bestScore);

            if (heights[left] < heights[right]) left++;
            else right--;
        }

        return bestScore;
    }
}
