/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int countheadA =0;
        int countheadB =0;
        ListNode dummyHeadA = headA;
        ListNode dummyHeadB = headB;
        while(headA != null || headB != null)
        {

            if(headA != null )
            {
                headA = headA.next;
                ++countheadA;
            } 

            if(headB != null )
            {
                headB = headB.next;
                ++countheadB;
            } 
        }

            int val = countheadA >countheadB ?
            countheadA -countheadB : countheadB -countheadA;
        
        while(val >0)
        {
            if(countheadA >countheadB)
            {
                dummyHeadA = dummyHeadA.next;
            }
            else
            {
                dummyHeadB = dummyHeadB.next;
            }

            --val;
        }

        while(dummyHeadA != null && dummyHeadB != null)
        {
            if(dummyHeadA == dummyHeadB) return dummyHeadA;

            dummyHeadA = dummyHeadA.next;
            dummyHeadB = dummyHeadB.next;
        }
        return null;
    }
}