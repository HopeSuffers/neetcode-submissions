public class Solution {
    public List<List<string>> SolveNQueens(int n)
    {
        var result = new List<List<string>>();

        var board = new char[n][];
        for (int row = 0; row < n; row++)
        {
            board[row] = new string('.', n).ToCharArray();
        }

        var usedColumns = new HashSet<int>();
        var usedPositiveDiagonals = new HashSet<int>();
        var usedNegativeDiagonals = new HashSet<int>();

        void Dfs(int row)
        {
            if (row == n)
            {
                var solution = new List<string>();

                foreach (var boardRow in board)
                {
                    solution.Add(new string(boardRow));
                }
                
                result.Add(solution);
                return;
            }

            for (int col = 0; col < n; col++)
            {
                int positiveDiagonal = row + col;
                int nevativeDiagonal = row - col;

                if (usedColumns.Contains(col) ||
                    usedPositiveDiagonals.Contains(positiveDiagonal) ||
                    usedNegativeDiagonals.Contains(nevativeDiagonal))
                {
                    continue;
                }

                board[row][col] = 'Q';
                usedColumns.Add(col);
                usedPositiveDiagonals.Add(positiveDiagonal);
                usedNegativeDiagonals.Add(nevativeDiagonal);
                
                Dfs(row + 1);

                board[row][col] = '.';
                usedColumns.Remove(col);
                usedPositiveDiagonals.Remove(positiveDiagonal);
                usedNegativeDiagonals.Remove(nevativeDiagonal);
            }
        }
        
        Dfs(0);
        return result;
    }
}
