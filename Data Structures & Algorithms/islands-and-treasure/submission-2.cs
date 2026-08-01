public class Solution {
     public void islandsAndTreasure(int[][] grid)
    {
        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if (grid[row][col] != int.MaxValue)
                    continue;

                int bestDistance = int.MaxValue;

                Dfs(row, col, 0);

                grid[row][col] = bestDistance;


                void Dfs(int currentRow, int currentCol, int distance)
                {
                    if (currentRow < 0 || currentRow >= grid.Length)
                        return;

                    if (currentCol < 0 || currentCol >= grid[0].Length)
                        return;

                    if (grid[currentRow][currentCol] == -1)
                        return;

                    if (distance >= bestDistance)
                        return;

                    if (grid[currentRow][currentCol] == 0)
                    {
                        bestDistance = Math.Min(bestDistance, distance);
                        return;
                    }

                    var original = grid[currentRow][currentCol];
                    grid[currentRow][currentCol] = -1;

                    Dfs(currentRow + 1, currentCol, distance + 1);
                    Dfs(currentRow - 1, currentCol, distance + 1);
                    Dfs(currentRow, currentCol + 1, distance + 1);
                    Dfs(currentRow, currentCol - 1, distance + 1);

                    grid[currentRow][currentCol] = original;
                }
            }
        }
    }
}
