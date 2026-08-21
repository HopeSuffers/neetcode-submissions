public class Solution {
    public int ClimbStairs(int n)
    {
        int one = 1;
        int two = 1;
        
        for (int i = 1; i < n; i++)
        {
            var tmp = one;
            one += two;
            two = tmp;
        }

        return one;
    }
}
