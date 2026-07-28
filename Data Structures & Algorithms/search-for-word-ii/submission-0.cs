public class Solution
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new();
        public string Word;
    }

    public List<string> FindWords(char[][] board, string[] words)
    {
        var root = new TrieNode();
        var result = new List<string>();
        foreach (string word in words)
        {
            TrieNode current = root;

            foreach (char character in word)
            {
                if (!current.Children.ContainsKey(character))
                    current.Children[character] = new TrieNode();

                current = current.Children[character];
            }

            current.Word = word;
        }

        int rows = board.Length;
        int colums = board[0].Length;

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < colums; column++)
            {
                Dfs(row, column, root);
            }
        }

        return result;

        void Dfs(int row, int column, TrieNode current)
        {
            if (row < 0 || row >= rows || column < 0 || column >= colums)
                return;

            char character = board[row][column];

            if (character == '#')
                return;

            if (!current.Children.ContainsKey(character))
                return;

            TrieNode next = current.Children[character];

            if (next.Word != null)
            {
                result.Add(next.Word);
                next.Word = null;
            }

            board[row][column] = '#';

            Dfs(row - 1, column, next);
            Dfs(row + 1, column, next);
            Dfs(row, column - 1, next);
            Dfs(row, column + 1, next);

            // Restore it for other search paths.
            board[row][column] = character;
        }
    }
}