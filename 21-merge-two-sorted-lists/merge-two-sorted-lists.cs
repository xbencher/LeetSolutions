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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode temp = new ListNode(-1);
        ListNode dummy = temp;

        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                dummy.next=list1;
                list1 = list1.next;
            }
            else
            {
                dummy.next=list2;
                list2 = list2.next;
            }

            dummy = dummy.next;
        }

        dummy.next = list1 == null ? list2 : list1;

        return temp.next;
    }
}