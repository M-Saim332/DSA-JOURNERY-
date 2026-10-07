/*
Problem Name: Squares of a Sorted Array
LeetCode: 977

Problem:
Given a sorted integer array, return an array containing the
squares of each number, also sorted in non-decreasing order.

Approach:
First, traverse the array and replace every element with its
square.

After squaring all elements, the array may no longer be sorted
because negative numbers can become larger after squaring.

Use Array.Sort() to sort the squared values in ascending order.

Finally, return the sorted array.

Time Complexity: O(n log n)
Space Complexity: O(1)

Key Concepts:
- Array Traversal
- Squaring Elements
- Array Sorting
- In-Place Modification
*/
public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        for(int i=0;i<nums.Length;i++){
            nums[i]=nums[i]*nums[i];
            
        }
        Array.Sort(nums);
        return nums;

    }
}
