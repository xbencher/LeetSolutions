/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        ListNode tempNode = node;
        while(node != null)
        {
            if(node.next != null)
            {
                node.val = node.next.val;
            }

            if(node.next.next == null)
            {
                node.next = null;
            }
            node = node.next;
        }
    }
}