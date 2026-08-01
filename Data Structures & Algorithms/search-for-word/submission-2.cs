public class Solution {
    public bool Exist(char[][] board, string word) {
        var current = "";

        for (int row = 0; row < board.Length; row++) {
            for (int col = 0; col < board[0].Length; col++) {
                if (Dfs(row, col, 0))
                    return true;
            }
        }

        return false;

        bool Dfs(int row, int col, int index) {
            if (index >= word.Length)
                return true;

            if (row < 0 || row >= board.Length)
                return false;

            if (col < 0 || col >= board[0].Length)
                return false;

            if (board[row][col] != word[index])
                return false;

            var original = board[row][col];
            board[row][col] = '#';

            var result = Dfs(row + 1, col, index + 1) || Dfs(row - 1, col, index + 1) ||
                         Dfs(row, col + 1, index + 1) || Dfs(row, col - 1, index + 1);

            board[row][col] = original;

            return result;
        }
    }
}
