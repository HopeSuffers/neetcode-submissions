public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var islandCounter = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if (Dfs(row, col))
                    islandCounter++;
            }
        }

        return islandCounter;

        bool Dfs(int row, int col)
        {
            if (row < 0 || row >= grid.Length)
                return false;

            if (col < 0 || col >= grid[0].Length)
                return false;

            if (grid[row][col] != '1')
                return false;

            var result = true;
            grid[row][col] = '#';

            Dfs(row + 1, col);
            Dfs(row - 1, col);
            Dfs(row, col + 1);
            Dfs(row, col - 1);
                   return result;
        }
    }
}