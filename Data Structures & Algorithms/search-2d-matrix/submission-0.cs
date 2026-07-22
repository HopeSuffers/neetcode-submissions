public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var colums = matrix[0].Length;

        var left = 0;
        var right = rows * colums - 1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;

            var row = middle / colums;
            var col = middle % colums;

            var value = matrix[row][col];
            if (value == target)
                return true;

            if (value < target)
                left = middle + 1;
            else right = middle - 1;
        }

        return false;
    }
}
