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
            if (!current.dic.ContainsKey(c))
                current.dic.Add(c, new TrieNode());

            current = current.dic[c];
        }

        current.isEndOfWord = true;
    }

    public bool Search(string word)
    {
        var current = root;
        
        foreach (var c in word)
        {
            if (!current.dic.ContainsKey(c))
                return false;

            current = current.dic[c];
        }

        return current.isEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var current = root;
        
        foreach (var c in prefix)
        {
            if (!current.dic.ContainsKey(c))
                return false;

            current = current.dic[c];
        }

        return true;
    }
}