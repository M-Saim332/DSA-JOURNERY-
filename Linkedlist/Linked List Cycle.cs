/*
Problem Name: Linked List Cycle
LeetCode: 141

Problem:
Given the head of a linked list, determine whether the linked
list contains a cycle.

A cycle exists when a node's next pointer points back to a
previously visited node.

Approach:
Use Floyd's Cycle Detection Algorithm, also known as the
Slow and Fast Pointer technique.

Initialize two pointers, slow and fast, at the head.

1. Move slow one node at a time.
2. Move fast two nodes at a time.
3. If slow and fast point to the same node, a cycle exists,
   so return true.
4. If fast or fast.next becomes null, the list has no cycle,
   so return false.

If a cycle exists, the fast pointer eventually catches up
with the slow pointer.

Time Complexity: O(n)
Space Complexity: O(1)

Key Concepts:
- Singly Linked List
- Two-Pointer Technique
- Floyd's Cycle Detection Algorithm
- Reference Comparison
*/
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
        ListNode slow=head;
        ListNode fast=head;
        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;

            if(slow==fast){
                return true;
            }
            
        }
        return false;
        

        
    }
}
