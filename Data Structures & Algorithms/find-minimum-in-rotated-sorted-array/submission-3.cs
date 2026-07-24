public class Solution {
    public int FindMin(int[] piles)
    {
        var left = 0;
        var right = piles.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (piles[mid] > piles[right])
                left = mid + 1;
            else right = mid;
        }

        return piles[left];
    }
}