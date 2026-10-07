/*
Problem Name: Missing Number
LeetCode: 268

Problem:
Given an array containing n distinct numbers taken from the
range [0, n], find the one number that is missing from the array.

Approach:
Use the XOR operation to find the missing number.

Initialize xor with nums.Length because the range contains
numbers from 0 to n.

Then traverse the array and XOR:
- the current index i
- the current array value nums[i]

XOR has the property that:
- x ^ x = 0
- x ^ 0 = x

Therefore, all numbers that appear both in the expected range
and in the array cancel each other out. The only number left
is the missing number.

Time Complexity: O(n)
Space Complexity: O(1)

Key Concepts:
- XOR
- Bit Manipulation
- Array Traversal
- Cancellation Property of XOR
*/

public class Solution {
    public int MissingNumber(int[] nums) {
        int xor=nums.Length;
        for (int i=0;i<nums.Length;i++){
            xor^=i;
            xor^=nums[i];

        }
        return xor;
        
    }
}
