public class Solution {
    public void Solve(char[][] board) {
        int[][] directions =
            new int[][] { new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 0, -1 } };

        char[][] newBoard = new char [board.Length][];

        for (int row = 0; row < board.Length; row++) {
            newBoard[row] = new char[board[row].Length];

            for (int col = 0; col < board[row].Length; col++) {
                newBoard[row][col] = 'X';
            }
        }

        for (int row = 0; row < board.Length; row++) {
            for (int col = 0; col < board[row].Length; col++) {
                if (row != 0 && col != 0 && row != board.Length - 1 && col != board[row].Length - 1)
                    continue;

                if (board[row][col] == 'O')
                    Dfs(row, col);
            }
        }

        for (int row = 0; row < board.Length; row++) {
            for (int col = 0; col < board[row].Length; col++) {
                board[row][col] = newBoard[row][col];
            }
        }

        void Dfs(int row, int col) {
            newBoard[row][col] = 'O';

            foreach (var direction in directions) {
                var nextRow = row + direction[0];
                var nextCol = col + direction[1];

                if (nextRow < 0 || nextRow >= board.Length)
                    continue;

                if (nextCol < 0 || nextCol >= board[nextRow].Length)
                    continue;

                if (board[nextRow][nextCol] != 'O')
                    continue;

                if (newBoard[nextRow][nextCol] != 'X')
                    continue;

                Dfs(nextRow, nextCol);
            }
        }
    }
}
