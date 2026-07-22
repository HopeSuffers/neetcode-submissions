public class Solution {
    public int Trap(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;

        var leftMax = 0;
        var rightMax = 0;

        var waterBest = 0;
        
        while (left < right)
        {
            if (height[left] <= height[right])
            {
                leftMax = Math.Max(height[left], leftMax);
                waterBest += leftMax - height[left];
                left++;
            }
            else
            {
                rightMax = Math.Max(height[right], rightMax);
                waterBest += rightMax - height[right];
                right--;
            }
        }

        return waterBest;
    }
}
