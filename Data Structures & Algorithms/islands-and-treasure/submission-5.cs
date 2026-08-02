public class Solution {
    public void islandsAndTreasure(int[][] grid)
    {
        var quene = new Queue<(int row, int col)>();

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[row].Length; col++)
            {
                if (grid[row][col] == 0)
                    quene.Enqueue((row, col));
            }
        }

        int[][] directions = new[]
        {
            new[] { 1, 0 },
            new[] { -1, 0 },
            new[] { 0, 1 },
            new[] { 0, -1 }
        };

        while (quene.Count > 0)
        {
            (var currentRow, var currentCol) = quene.Dequeue();

            foreach (var direction in directions)
            {
                var nextRow = currentRow + direction[0];
                var nextCol = currentCol + direction[1];

                if (nextRow < 0 || nextRow >= grid.Length)
                    continue;

                if (nextCol < 0 || nextCol >= grid[nextRow].Length)
                    continue;

                if (grid[nextRow][nextCol] != int.MaxValue)
                    continue;

                grid[nextRow][nextCol] = grid[currentRow][currentCol] + 1;
                quene.Enqueue((nextRow, nextCol));
            }
        }
    }
}
