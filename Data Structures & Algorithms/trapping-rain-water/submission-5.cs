public class Solution {
    public int Trap(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;

        var leftMax = height[left];
        var rightMax = height[right];

        var water = 0;
        
        while (left < right)
        {
            if (height[left] < height[right])
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                water += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                water += rightMax - height[right];
            }
        }

        return water;
    }
}
