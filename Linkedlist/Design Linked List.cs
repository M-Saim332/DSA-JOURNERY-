/*
Problem Name: Design Linked List
LeetCode: 707

Problem:
Design a singly linked list that supports retrieving, adding,
and deleting nodes at specific positions.

Implement the following operations:
- Get(index): Return the value at the given index, or -1 if
  the index is invalid.
- AddAtHead(val): Insert a node at the beginning.
- AddAtTail(val): Insert a node at the end.
- AddAtIndex(index, val): Insert a node at the specified index.
- DeleteAtIndex(index): Delete the node at the specified index.

Approach:
Implement a singly linked list using a Node class containing
a value and a reference to the next node.

Maintain a head pointer to represent the first node and a size
variable to track the total number of nodes.

1. Get:
   Validate the index, traverse the list to the target node,
   and return its value.

2. AddAtHead:
   Create a new node, connect it to the current head, and
   update head to the new node.

3. AddAtTail:
   Create a new node. If the list is empty, make it the head.
   Otherwise, traverse to the last node and attach the new node.

4. AddAtIndex:
   Validate the index. If index is 0, insert at the head.
   Otherwise, traverse to the node before the target position,
   connect the new node to the next node, and update the link.

5. DeleteAtIndex:
   Validate the index. If index is 0, update head to head.next.
   Otherwise, traverse to the node before the target and skip
   the node being deleted.

Update size after every successful insertion or deletion.

Time Complexity:
- Get: O(n)
- AddAtHead: O(1)
- AddAtTail: O(n)
- AddAtIndex: O(n)
- DeleteAtIndex: O(n)

Space Complexity:
- O(n) for storing the linked list nodes.
- O(1) auxiliary space per operation.

Key Concepts:
- Singly Linked List
- Classes and Objects
- Node Creation
- Pointer Manipulation
- Index-Based Traversal
- Insertion and Deletion
- Edge Case Handling
*/

public class MyLinkedList {

    public class Node {
        public int val;
        public Node next;

        public Node(int val) {
            this.val = val;
        }
    }

    public Node head;
    public int size = 0;

    public MyLinkedList() {
    }

    public int Get(int index) {
        if (index < 0 || index >= size)
            return -1;

        Node curr = head;

        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }

        return curr.val;
    }

    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        size++;
    }

    public void AddAtTail(int val) {
        Node newNode = new Node(val);

        if (head == null) {
            head = newNode;
        }
        else {
            Node curr = head;

            while (curr.next != null) {
                curr = curr.next;
            }

            curr.next = newNode;
        }

        size++;
    }

    public void AddAtIndex(int index, int val) {
        if (index < 0 || index > size)
            return;

        if (index == 0) {
            AddAtHead(val);
            return;
        }

        Node curr = head;

        for (int i = 0; i < index - 1; i++) {
            curr = curr.next;
        }

        Node newNode = new Node(val);
        newNode.next = curr.next;
        curr.next = newNode;
        size++;
    }

    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size)
            return;

        if (index == 0) {
            head = head.next;
        }
        else {
            Node curr = head;

            for (int i = 0; i < index - 1; i++) {
                curr = curr.next;
            }

            curr.next = curr.next.next;
        }

        size--;
    }
}
