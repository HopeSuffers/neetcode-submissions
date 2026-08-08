public class Solution {
    public int ClimbStairs(int n) {
        var one = 1;
        var two = 1;

        for (int i = 1; i < n; i++) {
            var tmp = one;
            one = one + two;
            two = tmp;
        }

        return one;
    }
}