/*
Problem Name: Kth Largest Element in an Array
LeetCode: 215

Problem:
Given an integer array nums and an integer k, return the kth
largest element in the array.

The kth largest element is determined by sorted order, not
by the number of distinct elements.

Approach:
First, use Array.Sort() to sort the array in ascending order.

Then, use Array.Reverse() to reverse the array into descending
order, placing the largest element at index 0.

Finally, return nums[k - 1] because array indexing starts
from 0, so the kth largest element is at index k - 1.

Time Complexity: O(n log n)
Space Complexity: O(n) auxiliary space for the sorting
and reversing operations, depending on implementation.

Key Concepts:
- Array Sorting
- Array Reversal
- Zero-Based Indexing
- Descending Order
*/
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Array.Sort(nums);
        Array.Reverse(nums);

        return nums[k - 1];
    }
}
