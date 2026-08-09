public class Solution {
    public int ClimbStairs(int n) {
        var one = 1;
        var two = 1;

        for (int i = 1; i < n; i++) {
            var temp = one;
            one = one + two;
            two = temp;
        }

        return one;
    }
}