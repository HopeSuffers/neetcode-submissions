public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;

        int[][] grid = new int [m + 1][];

        for (int i = 0; i <= m; i++) grid[i] = new int[n + 1];

        for (int i = 0; i <= m; i++) grid[i][0] = i;

        for (int i = 0; i <= n; i++) grid[0][i] = i;

        for (int row = 1; row <= m; row++) {
            for (int col = 1; col <= n; col++) {
                if (word1[row - 1] == word2[col - 1])
                    grid[row][col] = grid[row - 1][col - 1];
                else {
                    var up = grid[row][col - 1];
                    var down = grid[row - 1][col];
                    var diagonal = grid[row - 1][col - 1];

                    grid[row][col] = Math.Min(Math.Min(up, down), diagonal) + 1;
                }
            }
        }

        return grid[m][n];
    }
}
