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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        var current = dummy;
        var carry = 0;
        
        while (l1 != null || l2 != null || carry != 0)
        {
            var val1 = l1?.val ?? 0;
            var val2 = l2?.val ?? 0;
            
            var sum = val1 + val2 + carry;
            var digit = sum % 10;
            carry = sum / 10;

            current.next = new ListNode(digit);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return dummy.next;
    }
}
