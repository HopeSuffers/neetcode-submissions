/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        var dir = new Dictionary<Node, Node>();
        return Copy(head);

        Node Copy(Node current) {
            if (current == null)
                return null;

            if (dir.ContainsKey(current)) {
                return dir[current];
            }

            var copy = new Node(current.val);

            dir[current] = copy;

            copy.next = Copy(current.next);
            copy.random = Copy(current.random);
            return copy;
        }
    }
}
