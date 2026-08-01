public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        var maxIslandTiles = 0;
        var counter = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                counter = 0;
                Dfs(row, col);
                maxIslandTiles = Math.Max(maxIslandTiles, counter);
            }
        }

        return maxIslandTiles;

        void Dfs(int row, int col)
        {
            if (row < 0 || row >= grid.Length)
                return;

            if (col < 0 || col >= grid[0].Length)
                return;

            if (grid[row][col] != 1)
                return;

            counter++;
            grid[row][col] = 2;

            Dfs(row + 1, col);
            Dfs(row - 1, col);
            Dfs(row, col + 1);
            Dfs(row, col - 1);
        }
    }
}
