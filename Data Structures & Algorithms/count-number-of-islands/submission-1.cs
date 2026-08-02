public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var numIslands = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                var value = grid[row][col];
                if (value != '1')
                    continue;

                numIslands++;
                Bfs(row, col);
            }
        }

        // new[] { '0', '1', '1', '1', '0' },
        // new[] { '0', '1', '0', '1', '0' },
        // new[] { '1', '1', '0', '0', '0' },
        // new[] { '0', '0', '0', '0', '0' }

        return numIslands;

        void Bfs(int startRow, int startCol)
        {
            var queue = new Queue<(int startRow, int startCol)>();
            queue.Enqueue((startRow, startCol));

            grid[startRow][startCol] = '0';

            while (queue.Count > 0)
            {
                var value = queue.Dequeue();

                int[][] directions = new[]
                {
                    new[] { 1, 0 },
                    new[] { -1, 0 },
                    new[] { 0, 1 },
                    new[] { 0, -1 },
                };

                foreach (var direction in directions)
                {
                    var nextRow = value.startRow + direction[0];
                    var nextCol = value.startCol + direction[1];

                    if (nextRow < 0 || nextRow >= grid.Length)
                        continue;

                    if (nextCol < 0 || nextCol >= grid[0].Length)
                        continue;

                    if (grid[nextRow][nextCol] != '1')
                        continue;

                    queue.Enqueue((nextRow, nextCol));
                    grid[nextRow][nextCol] = '0';
                }
            }
        }
    }
}