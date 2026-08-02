public class Solution {
    public void islandsAndTreasure(int[][] grid)
    {
        var queue = new Queue<(int row, int col)>();

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[row].Length; col++)
            {
                if (grid[row][col] == 0)
                    queue.Enqueue((row, col));
            }
        }

        int[][] directions =
        {
            new[] { -1, 0 },
            new[] { 1, 0 },
            new[] { 0, -1 },
            new[] { 0, 1 }
        };

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            foreach (var direction in directions)
            {
                var row = current.row + direction[0];
                var col = current.col + direction[1];

                if (row< 0 || row >= grid.Length)
                    continue;
                if (col < 0 ||col >= grid[row].Length)
                    continue;

                if (grid[row][col] != int.MaxValue)
                    continue;

                grid[row][col] = grid[current.row][current.col] + 1;
                queue.Enqueue((row, col));
            }
        }
    }
}
