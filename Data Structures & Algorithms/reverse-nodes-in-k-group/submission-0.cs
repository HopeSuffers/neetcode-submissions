/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var groupEnd = head;

        for (int i = 0; i < k; i++)
        {
            if (groupEnd == null)
                return head;

            groupEnd = groupEnd.next;
        }

        ListNode previous = groupEnd;
        var current = head;

        for (int i = 0; i < k; i++)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        head.next = ReverseKGroup(groupEnd, k);

        return previous;
    }
}
