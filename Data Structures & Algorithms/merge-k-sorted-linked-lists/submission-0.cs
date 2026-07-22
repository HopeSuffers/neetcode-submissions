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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
            return null; 
            
        ListNode listNode = new ListNode();

        for (int i = 1; i < lists.Length; i++)
        {
            if (i == 1)
            {
                listNode = MergeTwoLists(lists[0], lists[1]);
                continue;
            }

            listNode = MergeTwoLists(listNode, lists[i]);
        }

        return listNode;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        var current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
    }
}
