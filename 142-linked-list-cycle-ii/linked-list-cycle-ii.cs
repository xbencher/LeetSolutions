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
    public ListNode DetectCycle(ListNode head) {
        
        Dictionary<ListNode,int>  dict= new Dictionary<ListNode,int>();

        while(head != null)
        {
            if(dict.ContainsKey(head))
            {
                return head;
            }
            
            dict.Add(head,0);
            head = head.next;
        }

        return null;

    }
}