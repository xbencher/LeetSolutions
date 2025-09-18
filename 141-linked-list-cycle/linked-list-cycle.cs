/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> dict = new HashSet<ListNode>();

        ListNode dummy = head;
        
        while(dummy != null)
        {
            if(dict.Contains(dummy)) return true;

            dict.Add(dummy);
            dummy = dummy.next;
        }

        return false;
    }
}