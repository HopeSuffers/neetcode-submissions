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
            var valuel1 = l1?.val ?? 0;
            var valuel2 = l2?.val ?? 0;

            var sum = valuel2 + valuel1 + carry;
            var modulo = sum % 10;
            carry = sum / 10;

            current.next = new ListNode(modulo);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return dummy.next;
    }
}
