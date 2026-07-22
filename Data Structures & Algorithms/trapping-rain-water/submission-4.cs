public class Solution {
     public int Trap(int[] height)
    {
        if (height.Length == 0)
            return 0;

        int left = 0;
        int right = height.Length - 1;

        int leftMax = height[left];
        int rightMax = height[right];

        int water = 0;

        while (left < right)
        {
            if (leftMax < rightMax)
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
