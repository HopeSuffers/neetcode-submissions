public class Node
{
    public int key;
    public int val;
    public Node next;
    public Node prev;

    public Node(int _key = 0, int _val = 0)
    {
        key = _key;
        val = _val;
        next = null;
        prev = null;
    }
}

public class LRUCache
{
    private Dictionary<int, Node> dic;
    private Node left;
    private Node right;
    private int capacity = 2;

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

        Node node = dic[key];
        Remove(node);
        Insert(node);
        return node.val;
    }

    public void Put(int key, int value) {
        if (dic.ContainsKey(key))
        {
            var node = dic[key];
            node.val = value;
            
            Remove(node);
            Insert(node);
            return;
        }
        
        var newNode = new Node(key, value);
        Insert(newNode);
        dic.Add(key, newNode);

        if (dic.Count <= capacity) 
            return;
        
        var lru = left.next;
        dic.Remove(lru.key);
        Remove(lru);
    }

    void Remove(Node node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    void Insert(Node node)
    {
        var prev = right.prev;
        prev.next = node;
        node.prev = prev;
        node.next = right;
        right.prev = node;
    }
}