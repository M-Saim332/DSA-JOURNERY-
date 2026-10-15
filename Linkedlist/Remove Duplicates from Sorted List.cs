/*
Problem Name: Remove Duplicates from Sorted List
LeetCode: 83

Problem:
Given the head of a sorted linked list, remove all duplicate
values so that each value appears only once. Return the
head of the modified linked list.

Approach:
Use a current pointer to traverse the linked list.

While the current node and its next node are not null:
1. Compare the current node's value with the next node's value.
2. If both values are equal, skip the next node by updating
   curr.next = curr.next.next.
3. Otherwise, move the current pointer to the next node.
4. Continue until the end of the list.

Since the list is sorted, duplicate values appear consecutively.
When a duplicate is found, keep the current pointer in place
to check whether more duplicates follow.

Finally, return the original head of the modified list.

Time Complexity: O(n)
Space Complexity: O(1)

Key Concepts:
- Singly Linked List
- Pointer Manipulation
- In-Place Modification
- Duplicate Removal
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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode curr=head;
        while (curr != null && curr.next != null) {
        if(curr.val==curr.next.val){
            curr.next=curr.next.next;
        }else{
            curr=curr.next;
        }
        }
        return head;





    }
}
