public class Solution {
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;

        int[][] grid = new int[m + 1][];
        for (int i = 0; i < m + 1; i++)
        {
            grid[i] = new int[n + 1];
        }

        for (int i = 0; i < m + 1; i++)
            grid[i][0] = i;

        for (int i = 0; i < n + 1; i++)
            grid[0][i] = i;

        for (int i = 1; i < m + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                if (word1[i-1] == word2[j-1])
                {
                    grid[i][j] = grid[i - 1][j - 1];
                }
                else
                {
                    var insert = grid[i][j - 1];
                    var delete = grid[i - 1][j];
                    var replace = grid[i - 1][j - 1];

                    grid[i][j] = Math.Min(Math.Min(insert, delete), replace) + 1;
                }
            }
        }

        return grid[m][n];
    }
}
