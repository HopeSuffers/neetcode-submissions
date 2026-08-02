public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights)
    {
        var pacific = new HashSet<(int row, int col)>();
        var atlantic = new HashSet<(int row, int col)>();

        int[][] directions = new int[][]
        {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };

        for (int row = 0; row < heights.Length; row++)
        {
            for (int col = 0; col < heights[row].Length; col++)
            {

                if (row == 0 || col == 0)
                    Dfs(row, col, pacific);

                if (row == heights.Length - 1 || col == heights[row].Length - 1)
                    Dfs(row, col, atlantic);
            }
        }

        return (from valueTuple in pacific where atlantic.Contains(valueTuple) select new List<int>() { valueTuple.row, valueTuple.col }).ToList();

        void Dfs(int row, int col, HashSet<(int row, int col)> hashSet)
        {
            if (!hashSet.Add((row, col)))
                return;

            foreach (var direction in directions)
            {
                var nextRow = row + direction[0];
                var nextCol = col + direction[1];

                if (nextRow < 0 || nextRow >= heights.Length)
                    continue;

                if (nextCol < 0 || nextCol >= heights[nextRow].Length)
                    continue;

                if (heights[nextRow][nextCol] < heights[row][col])
                    continue;

                Dfs(nextRow, nextCol, hashSet);
            }
        }


    }
}