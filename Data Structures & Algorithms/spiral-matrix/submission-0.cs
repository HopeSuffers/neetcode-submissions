public class Solution {
    public List<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();

        var top = 0;
        var bottom = matrix.Length - 1;
        var left = 0;
        var right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (int col = left; col <= right; col++)
                result.Add(matrix[top][col]);

            top++;

            for (int row = top; row <= bottom; row++)
                result.Add(matrix[row][right]);

            right--;

            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    result.Add(matrix[bottom][col]);

                bottom--;
            }

            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    result.Add(matrix[row][left]);

                left++;
            }
        }

        return result;
    }
}
