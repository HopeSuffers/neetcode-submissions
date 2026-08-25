public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s3.Length > s1.Length + s2.Length)
            return false;

        if (s1.Length + s2.Length > s3.Length)
            return false;

        var memo = new Dictionary<(int, int), bool>();
        return Dfs(0, 0);

        bool Dfs(int i, int j) {
            if (i == s1.Length && j == s2.Length)
                return true;

            if (memo.ContainsKey((i, j)))
                return memo[(i, j)];

            int k = i + j;
            var result = false;

            if (i < s1.Length && s1[i] == s3[k])
                result |= Dfs(i + 1, j);

            if (j < s2.Length && s2[j] == s3[k])
                result |= Dfs(i, j + 1);

            memo.Add((i, j), result);
            return result;
        }
    }
}
