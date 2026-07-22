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

public void ReorderList(ListNode head) {
        // Finde middle of list

        // Detech middle from list and reverse

        // Add to new node from left and right
    }


    public class Solution {
    public void ReorderList(ListNode head) {
        // Finde middle of list
        var fast = head;
        var slow = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        
        // Detech middle from list and reverse
        ListNode previous = null;
        var current = slow.next;
        slow.next = null;

        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        
        // Add to new node from left and right
        var first = head;
        var second = previous;

        while (second != null)
        {
            var firstNext = first.next;
            var secondNext = second.next;

            first.next = second;
            second.next = firstNext;

            first = firstNext;
            second = secondNext;
        }
    }
}
