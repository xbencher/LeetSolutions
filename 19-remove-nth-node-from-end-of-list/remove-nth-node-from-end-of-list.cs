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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count =0;
        ListNode temp = head;
        while(temp != null)
        {
            ++count;
            temp = temp.next;
        }

        int val = count - n;

        if(val == 0) return head.next;

        ListNode current = head;
        for(int i=1; i<val;++i)
        {
                current = current.next;
        }

        current.next = current.next?.next ; 
        return head;
    }
}