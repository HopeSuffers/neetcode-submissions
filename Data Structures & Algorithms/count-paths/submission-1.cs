public class Solution {
    public int UniquePaths(int m, int n) {
        var row = new int[n];
        Array.Fill(row, 1);

        for (int i = 1; i < m; i++)
            for (int j = 1; j < n; j++) row[j] += row[j - 1];

        return row[n - 1];
    }
}