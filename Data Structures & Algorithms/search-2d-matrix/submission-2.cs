public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var left = 0;
        var right = cols * rows - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            var col = mid % cols;
            var row = mid / cols;

            var value = matrix[row][col];
            
            if (value == target)
                return true;

            if (value < target)
                left = mid + 1;
            else right = mid - 1;
        }

        return false;
    }
}
