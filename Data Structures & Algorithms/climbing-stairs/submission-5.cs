public class Solution {
    public int ClimbStairs(int n)
    {
        int one = 1;
        int two = 1;

        for (int o = 1; o < n; o++)
        {
            int tmp = one;
            one = two + one;
            two = tmp;
        }

        return one;
    }
}
