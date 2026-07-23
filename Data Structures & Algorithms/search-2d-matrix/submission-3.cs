public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var left = 0;
        var right = rows * cols - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            var col = mid % cols;
            var row = mid / cols;

            int num = matrix[row][col];
            if (num == target)
                return true;
            if (num < target)
                left = mid + 1;
            else right = mid - 1;
        }

        return false;
    }
}
