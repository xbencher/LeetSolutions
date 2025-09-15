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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode initial = new ListNode(-1);
        ListNode dummy = initial;
        int carry =0;

        while(l1 != null || l2 != null)
        {
            int sum=0;

            if(l1 != null && l2 != null)
            {
                sum = l1.val+l2.val + carry;
                carry = sum/10;
                l1 = l1.next;
                l2 = l2.next;
            }
            else if(l1 != null)
            {
                sum = l1.val+ carry;
                carry = sum/10;
                l1 = l1.next;
            }
            else
            {
                sum = l2.val + carry;
                carry = sum/10;
                l2 = l2.next;
            }

            dummy.next = new ListNode(sum%10);
            dummy = dummy.next;
        }

        if(carry > 0)
        {
            dummy.next = new ListNode(carry);
        }
        
        return initial.next; 

    }
}