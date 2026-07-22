public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] row = new HashSet<char> [board.Length];
        HashSet<char>[] col = new HashSet<char> [board.Length];
        HashSet<char>[] squareHashSet = new HashSet<char> [board.Length];

        for (int i = 0; i < board.Length; i++)
        {
            row[i] = new HashSet<char>();
            col[i] = new HashSet<char>();
            squareHashSet[i] = new HashSet<char>();
        }
        
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                var value = board[i][j];
                
                if (value == '.')
                    continue;
                
                var square = (i / 3) * 3 + (j / 3);
                if (row[i].Contains(value) || col[j].Contains(value) ||
                    squareHashSet[square].Contains(value))
                    return false;

                row[i].Add(value);
                col[j].Add(value);
                squareHashSet[square].Add(value);
            }
        }

        return true;
    }
}
