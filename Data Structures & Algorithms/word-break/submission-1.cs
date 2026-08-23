public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        var dp = new bool[s.Length + 1];
        dp[s.Length] = true;

        for (int i = s.Length - 1; i >= 0; i--) {
            foreach (var word in wordDict) {
                if (s.Length - i < word.Length)
                    continue;

                if (s.Substring(i, word.Length) != word || !dp[i + word.Length])
                    continue;

                dp[i] = true;
                break;
            }
        }

        return dp[0];
    }
}
