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
    public ListNode MiddleNode(ListNode head) {
        int count =0;
        ListNode tempHead = head;
        ListNode resultNode = head;
        while(tempHead != null)
        {
            ++count;
            tempHead = tempHead.next;
        }
    
        Console.WriteLine(count);

        count = count/2;

        Console.WriteLine(count);

        while(count > 0)
        {
            resultNode = resultNode.next;
            --count;
        }
        return resultNode;
    }
}