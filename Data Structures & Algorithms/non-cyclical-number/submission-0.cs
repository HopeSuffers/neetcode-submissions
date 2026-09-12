public class Solution {
    public bool IsHappy(int n)
    {
        var hasSet = new HashSet<int>();

        while (!hasSet.Contains(n))
        {
            hasSet.Add(n);
            n = SquareAndAddNumber(n);

            if (n != 1)
                continue;

            return true;
        }

        return false;

        int SquareAndAddNumber(int i)
        {
            var result = 0;

            while (i > 0)
            {
                var number = i % 10;
                i /= 10;
                result += number * number;
            }

            return result;
        }
    }
}
