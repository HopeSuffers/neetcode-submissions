public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s))
            return "";

        if (s.Length < 2)
            return s;

        var bestStart = 0;
        var bestEnd = 1;

        for (int i = 0; i < s.Length; i++) {
            Expand(i, i);
            Expand(i, i + 1);
        }

        return s.Substring(bestStart, bestEnd);

        void Expand(int left, int right) {
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                var length = right - left + 1;
                if (length >= bestEnd) {
                    bestStart = left;
                    bestEnd = length;
                }

                left--;
                right++;
            }
        }
    }
}