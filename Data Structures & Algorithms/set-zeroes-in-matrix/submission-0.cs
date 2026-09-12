public class Solution {
    public void SetZeroes(int[][] matrix)
    {
        var rowsZero = new HashSet<int>();
        var colsZero = new HashSet<int>();

        // first pass
        for (var row = 0; row < matrix.Length; row++)
        {
            for (var col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[row][col] != 0)
                    continue;

                rowsZero.Add(row);
                colsZero.Add(col);
            }
        }

        // second pass
        for (var row = 0; row < matrix.Length; row++)
        {
            if (rowsZero.Contains(row))
            {
                Array.Fill(matrix[row], 0);
                continue;
            }

            for (var col = 0; col < matrix[0].Length; col++)
            {
                if (!colsZero.Contains(col))
                    continue;

                matrix[row][col] = 0;
            }
        }
    }
}
