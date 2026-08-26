public class Solution {
    public int LongestIncreasingPath(int[][] matrix)
    {
        int[][] memoGrid = new int[matrix.Length][];

        for (int i = 0; i < matrix.Length; i++)
            memoGrid[i] = new int[matrix[0].Length];

        var max = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                max = Math.Max(Dfs(row, col), max);
            }
        }

        return max;

        int Dfs(int curRow, int curCol)
        {
            if (memoGrid[curRow][curCol] != 0)
                return memoGrid[curRow][curCol];

            int longest = 1;

            if (curRow + 1 >= 0 && curRow + 1 < matrix.Length && matrix[curRow + 1][curCol] > matrix[curRow][curCol])
                longest = Math.Max(longest, 1 + Dfs(curRow + 1, curCol));

            if (curRow - 1 >= 0 && curRow - 1 < matrix.Length && matrix[curRow - 1][curCol] > matrix[curRow][curCol])
                longest = Math.Max(longest, 1 + Dfs(curRow - 1, curCol));

            if (curCol + 1 >= 0 && curCol + 1 < matrix[0].Length && matrix[curRow][curCol + 1] > matrix[curRow][curCol])
                longest = Math.Max(longest, 1 + Dfs(curRow, curCol + 1));

            if (curCol - 1 >= 0 && curCol - 1 < matrix[0].Length && matrix[curRow][curCol - 1] > matrix[curRow][curCol])
                longest = Math.Max(longest, 1 + Dfs(curRow, curCol - 1));

            memoGrid[curRow][curCol] = longest;
            return longest;
        }
    }
}
