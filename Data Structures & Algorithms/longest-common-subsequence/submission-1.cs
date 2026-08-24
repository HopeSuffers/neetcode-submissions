public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        var m = text1.Length;
        var n = text2.Length;
        var prev = new int[n + 1];
        var curr = new int[n + 1];
        Array.Fill(prev, 0);
        Array.Fill(curr, 0);

        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (text1[i - 1] == text2[j - 1])
                    curr[j] = prev[j - 1] + 1;
                else
                    curr[j] = Math.Max(prev[j], curr[j - 1]);
            }

            (prev, curr) = (curr, prev);
            Array.Fill(curr, 0);
        }

        return prev[n];
    }
}
