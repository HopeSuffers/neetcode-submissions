public class Solution
{
    public int SwimInWater(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var minHeap = new PriorityQueue<(int row, int col), int>();
        var visited = new bool[rows][];

        for (int i = 0; i < rows; i++)
            visited[i] = new bool[cols];

        minHeap.Enqueue((0, 0), grid[0][0]);

        int[][] directions =
        {
            new int[] { 1, 0 },
            new int[] { 0, 1 },
            new int[] { -1, 0 },
            new int[] { 0, -1 }
        };

        while (minHeap.Count > 0)
        {
            minHeap.TryDequeue(out var current, out int currentWaterLevel);
            var row = current.row;
            var col = current.col;

            if (visited[row][col])
                continue;

            visited[row][col] = true;

            if (row == rows - 1 && col == cols - 1)
                return currentWaterLevel;

            foreach (var direction in directions)
            {
                int newRow = row + direction[0];
                int newCol = col + direction[1];

                if (newRow < 0 || newRow >= rows)
                    continue;

                if (newCol < 0 || newCol >= cols)
                    continue;

                if (visited[newRow][newCol])
                    continue;

                int newWaterLevel = Math.Max(currentWaterLevel, grid[newRow][newCol]);

                minHeap.Enqueue((newRow, newCol), newWaterLevel);
            }
        }

        return -1;
    }
}