public class Solution {
    public int ClimbStairs(int n) {
        var next = 1;
        var nextNext = 1;

        for (int i = n - 2; i >= 0; i--) {
            var temp = next;
            next += nextNext;
            nextNext = temp;
        }

        return next;
    }
}
