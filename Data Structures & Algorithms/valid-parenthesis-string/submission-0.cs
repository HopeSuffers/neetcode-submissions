public class Solution {
    public bool CheckValidString(string s)
    {
        var leftMin = 0;
        var leftMax = 0;

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    leftMin++;
                    leftMax++;
                    break;
                case ')':
                    leftMin--;
                    leftMax--;
                    break;
                case '*':
                    leftMin--;
                    leftMax++;
                    break;
            }

            if (leftMax < 0)
                return false;

            leftMin = Math.Max(leftMin, 0);
        }

        return leftMin == 0;
    }
}
