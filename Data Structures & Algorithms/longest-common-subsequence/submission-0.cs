public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[][] grid = new int [text1.Length + 1][];

        for (int row = 0; row <= text1.Length; row++) {
            grid[row] = new int[text2.Length + 1];
        }

        for (int row = 1; row <= text1.Length; row++) {
            for (int col = 1; col <= text2.Length; col++) {
                if (text1[row - 1] == text2[col - 1]) {
                    grid[row][col] = grid[row - 1][col - 1] + 1;
                    continue;
                }

                grid[row][col] = Math.Max(grid[row][col - 1], grid[row - 1][col]);
            }
        }

        return grid[text1.Length][text2.Length];
    }
}
