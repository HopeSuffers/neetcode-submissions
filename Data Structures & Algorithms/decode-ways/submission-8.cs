public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0')
            return 0;
            
        if (s.Length < 2)
            return 1;

        var next = 1;
        var nextNext = 1;

        for (int i = s.Length - 1; i >= 0; i--) {
            var current = 0;

            if (s[i] != '0') {
                current = next;

                if (i + 1 < s.Length) {
                    var value = (s[i] - '0') * 10 + s[i + 1] - '0';
                    if (value < 27) {
                        current += nextNext;
                    }
                }
            }

            nextNext = next;
            next = current;
        }

        return next;
    }
}