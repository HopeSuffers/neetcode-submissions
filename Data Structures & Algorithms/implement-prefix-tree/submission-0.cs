public class TrieNode
{
    public bool endOfWord;
    public Dictionary<char, TrieNode> children;

    public TrieNode()
    {
        endOfWord = false;
        children = new Dictionary<char, TrieNode>();
    }
}

public class PrefixTree
{
    private TrieNode root;

    public PrefixTree()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        var current = root;

        foreach (var c in word)
        {
            if (!current.children.ContainsKey(c))
                current.children.Add(c, new TrieNode());

            current = current.children[c];
        }

        current.endOfWord = true;
    }

    public bool Search(string word)
    {
        var current = root;

        foreach (var c in word)
        {
            if (!current.children.ContainsKey(c))
                return false;

            current = current.children[c];
        }

        return current.endOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var current = root;

        foreach (var c in prefix)
        {
            if (!current.children.ContainsKey(c))
                return false;

            current = current.children[c];
        }

        return true;
    }
}