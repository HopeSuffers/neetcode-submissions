public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        
        var left = 0;
        var right = rows * cols - 1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;

            var row = middle / cols;
            var col = middle % cols;

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
