public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = piles.Max();

        while (left < right)
        {
            var middle = left + (right - left) / 2;

            var timeTaken = 0;
            foreach (var pile in piles)
            {
                timeTaken += (pile + middle - 1) / middle;
            }

            if (timeTaken > h)
                left = middle + 1;
            else right = middle;
        }

        return left;
    }
}
