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
    public bool IsPalindrome(ListNode head) {
        //dummy head
        // find mid-node
        // from mid reverse link list
        //start compare with head and mid
        ListNode slow= head;
        ListNode fast= head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        slow = ReverseList(slow);

        while(slow != null) 
        {
            if(head.val != slow.val) return false;

            slow = slow.next;
            head = head.next;
        }

        return true;
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode dummy = null;
        ListNode nextNode = null;
        while(head != null)
        {
            nextNode = head.next;
            head.next = dummy;
            dummy = head;
            head =nextNode;
        }
       return dummy;
    }
}