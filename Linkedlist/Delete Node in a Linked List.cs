/*
Problem Name: Delete Node in a Linked List
LeetCode: 237

Problem:
Given a node in a singly linked list, delete that node without
access to the head of the list.

The given node is guaranteed not to be the last node.

Approach:
Since the head is not provided, we cannot traverse the list
to find the previous node.

Instead, copy the value of the next node into the given node
using node.val = node.next.val.

Then skip the next node by updating:
node.next = node.next.next.

This effectively removes the given node's original value from
the linked list without directly deleting the node itself.

Time Complexity: O(1)
Space Complexity: O(1)

Key Concepts:
- Singly Linked List
- Pointer Manipulation
- In-Place Modification
- Node Deletion Technique
*/
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
        node.val=node.next.val;
        node.next=node.next.next;
            
    } 
}
