public class Solution {
    public int CountSubstrings(string s) {
        var palindromCount = 0;

        for (int i = 0; i < s.Length; i++) {
            Expand(i, i);
            Expand(i, i + 1);
        }

        return palindromCount;

        void Expand(int left, int right) {
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                palindromCount++;
                left--;
                right++;
            }
        }
    }
}
