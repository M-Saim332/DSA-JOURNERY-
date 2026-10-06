/*
Problem Name: Sqrt(x)
LeetCode: 69

Problem:
Given a non-negative integer x, return the integer square root
of x.

The integer square root is the largest integer whose square is
less than or equal to x.

Approach:
Use Binary Search to find the square root.

For x < 2, directly return x.

Set the search range from 1 to x / 2.
For every iteration:
1. Calculate the middle value.
2. Check if mid * mid is less than or equal to x.
3. If it is, store mid as the answer and search on the right
   side for a larger possible value.
4. Otherwise, search on the left side.
5. Continue until the search range becomes empty.

A long is used for mid * mid to prevent integer overflow.

Time Complexity: O(log x)
Space Complexity: O(1)

Key Concepts:
- Binary Search
- Integer Square Root
- Overflow Handling
- Search Space Reduction
*/
public class Solution {
    public int MySqrt(int x) {
        if (x<2){
            return x;
        }
        int start=1;
        int end=x/2;
        int ans=0;
        while(start<=end){
            int mid =start -(start-end)/2;
            if (((long)mid*mid)<=x){
                ans=mid;
                start=mid+1;

            }else{
                end=mid-1;
            }
        }
        return ans;
        
    }
}
