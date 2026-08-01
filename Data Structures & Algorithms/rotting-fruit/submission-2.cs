public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        var maxDistance = 0;
        int[][] newGrid = new int[grid.Length][];

        for (int row = 0; row < grid.Length; row++)
        {
            newGrid[row] = new int[grid[0].Length];
            Array.Fill(newGrid[row], 0);
        }

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                var value = grid[row][col];
                if (value == 1)
                    newGrid[row][col] = int.MaxValue;
            }
        }


        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                var value = grid[row][col];
                if (value == 0)
                    continue;

                if (value == 1)
                    continue;

                Dfs(row, col, 0);
            }
        }

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if (newGrid[row][col] == int.MaxValue)
                    return -1;

                maxDistance = Math.Max(maxDistance, newGrid[row][col]);
            }
        }

        return maxDistance;

        void Dfs(int row, int col, int distance)
        {
            if (row < 0 || row >= grid.Length)
                return;

            if (col < 0 || col >= grid[0].Length)
                return;

            var value = grid[row][col];

            if (value == 0)
                return;

            if (value == 1 && distance >= newGrid[row][col])
                return;

            if (value == 1)
                newGrid[row][col] = distance;

            grid[row][col] = 0;

            Dfs(row + 1, col, distance + 1);
            Dfs(row - 1, col, distance + 1);
            Dfs(row, col + 1, distance + 1);
            Dfs(row, col - 1, distance + 1);

            grid[row][col] = value;
        }
    }
}