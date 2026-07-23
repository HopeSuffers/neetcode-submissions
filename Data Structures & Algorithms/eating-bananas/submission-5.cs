public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = piles.Max();

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var timeTaken = piles.Sum(pile => (pile + mid - 1) / mid);

            if (timeTaken <= h)
                right = mid;
            else left = mid + 1;
            
        }

        return left;
    }
}
