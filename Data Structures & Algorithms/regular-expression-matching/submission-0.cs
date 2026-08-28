public class Solution {
    public bool IsMatch(string s, string p)
    {
        var memo = new Dictionary<(int, int), bool>();
        return Dfs(0, 0);

       bool Dfs(int i, int j)
       {
           if (memo.ContainsKey((i, j)))
               return memo[(i, j)];

           if (j == p.Length)
               return i == s.Length;

           bool firstMatch = i < s.Length && (s[i] == p[j] || p[j] == '.'); 

           bool result;

           if (j + 1 < p.Length && p[j + 1] == '*')
               result = Dfs(i, j + 2) || firstMatch && Dfs(i + 1, j);
           else
               result = firstMatch && Dfs(i + 1, j + 1);

           memo[(i, j)] = result;
           return result;
       }
    }
}
