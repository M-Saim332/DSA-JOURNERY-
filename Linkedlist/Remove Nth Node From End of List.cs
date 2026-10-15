/*
Problem Name: Remove Nth Node From End of List
LeetCode: 19

Problem:
Given the head of a singly linked list and an integer n,
remove the nth node from the end of the list and return
the updated head.

Approach:
First, traverse the linked list to calculate its total
length m.

Then calculate the position of the node to remove from
the beginning using dest = m - n.

If dest == 0, the node to remove is the head, so return
head.next.

Otherwise, reset curr to head and traverse until reaching
the node immediately before the target node.

Skip the target node by updating:
curr.next = curr.next.next

Finally, return head.

Time Complexity: O(n)
Space Complexity: O(1)

Key Concepts:
- Singly Linked List
- Linked List Traversal
- Length Calculation
- Pointer Manipulation
- Edge Case Handling
*/
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
        ListNode curr=head;
        int m=0;
        while(curr!=null){
            m++;
            curr=curr.next;
        }
        curr=head;
        int dest=m-n;
        if (dest==0){
            return head.next;
        }
        for(int i=1;i<dest;i++){
            curr=curr.next;

        }
        curr.next=curr.next.next;
        return head;

        
    }
}
