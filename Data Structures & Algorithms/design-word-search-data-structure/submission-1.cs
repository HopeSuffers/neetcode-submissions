public class TrieNode
{
    public Dictionary<char, TrieNode> dic = new Dictionary<char, TrieNode>();
    public bool isEndOfWord;

    public TrieNode()
    {
        this.dic = new Dictionary<char, TrieNode>();
        this.isEndOfWord = false;
    }
}

public class WordDictionary
{
    private TrieNode root;

    public WordDictionary()
    {
        root = new TrieNode();
    }

    public void AddWord(string word)
    {
        var current = root;

        foreach (var c in word)
        {
            if (!current.dic.ContainsKey(c))
                current.dic.Add(c, new TrieNode());

            current = current.dic[c];
        }

        current.isEndOfWord = true;
    }

    public bool Search(string word)
    {
        return Dfs(root, 0);

        bool Dfs(TrieNode current, int index)
        {
            if (index == word.Length)
                return current.isEndOfWord;

            char character = word[index];

            if (character == '.')
            {
                return current.dic.Values
                    .Any(child => Dfs(child, index + 1));
            }

            if (!current.dic.ContainsKey(character))
                return false;

            return Dfs(current.dic[character], index + 1);
        }
    }
}
