public class Node
{
    public int key;
    public int value;
    public Node next;
    public Node prev;

    public Node(int _key = 0, int _value = 0)
    {
        key = _key;
        value = _value;
        next = null;
        prev = null;
    }
}

public class LRUCache
{
    private Dictionary<int, Node> dic;
    private int capacity;
    private Node left;
    private Node right;

    public LRUCache(int capacity)
    {
        dic = new Dictionary<int, Node>();
        this.capacity = capacity;
        left = new Node();
        right = new Node();

        left.next = right;
        right.prev = left;
    }

    public int Get(int key)
    {
        if (!dic.ContainsKey(key))
            return -1;

        var node = dic[key];
        Remove(node);
        Insert(node);
        return node.value;
    }

    public void Put(int key, int value)
    {
        if (dic.ContainsKey(key))
        {
            var node = dic[key];
            node.value = value;

            Remove(node);
            Insert(node);
            return;
        }

        var newNode = new Node(key, value);
        Insert(newNode);
        dic.Add(key, newNode);

        if (dic.Count > capacity)
        {
            var lfs = left.next;
            Remove(lfs);
            dic.Remove(lfs.key);
        }
    }

    void Remove(Node node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    void Insert(Node node)
    {
        right.prev.next = node;
        node.prev = right.prev;
        right.prev = node;
        node.next = right;
    }
}