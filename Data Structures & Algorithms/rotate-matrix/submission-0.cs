public class Solution {
   public void Rotate(int[][] matrix)
{
    int n = matrix.Length;

    int[][] newMatrix = new int[n][];
    for (int i = 0; i < n; i++)
    {
        newMatrix[i] = new int[n];
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix[j][n - 1 - i] = matrix[i][j];
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i][j] = newMatrix[i][j];
        }
    }
}
}
