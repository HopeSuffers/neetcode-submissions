public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = piles.Max();

        while (left < right)
        {
            var speed = left + (right - left) / 2;

            var hours = 0;

            foreach (var pile in piles)
            {
                hours += (pile + speed - 1) / speed;
            }

            if (hours <= h)
                right = speed;
            else left = speed + 1;
        }

        return left;
    }
}
