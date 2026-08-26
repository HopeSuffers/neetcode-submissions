public class Solution {
    public int NumDistinct(string s, string t) {
        var memo = new Dictionary<(int, int), int>();
        return Dfs(0, 0);

        int Dfs(int i, int j) {
            if (j == t.Length)
                return 1;

            if (i == s.Length)
                return 0;

            if (memo.ContainsKey((i, j)))
                return memo[(i, j)];

            var result = Dfs(i + 1, j);

            if (s[i] == t[j])
                result += Dfs(i + 1, j + 1);

            memo.Add((i, j), result);
            return result;
        }
    }
}
