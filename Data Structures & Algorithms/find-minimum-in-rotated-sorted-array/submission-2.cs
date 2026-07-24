public class Solution {
    public int FindMin(int[] piles)
    {
        var left = 0;
        var right = piles.Length - 1;

        while (left < right)
        {
            var middle = left + (right - left) / 2;

            if (piles[right] < piles[middle])
                left = middle + 1;
            else right = middle;

        }

        return piles[left];
    }
}