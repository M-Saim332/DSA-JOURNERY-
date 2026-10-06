/*
Problem Name: Climbing Stairs
LeetCode: 70

Problem:
You are climbing a staircase with n steps.
You can climb either 1 step or 2 steps at a time.
Find the total number of distinct ways to reach the top.

Approach:
The problem follows the Fibonacci pattern.
For each step, the number of ways to reach it is the sum
of the ways to reach the previous two steps.

Use two variables:
- a = number of ways to reach the previous-previous step
- b = number of ways to reach the previous step

For every step from 3 to n, calculate:
c = a + b

Then move the values forward:
a = b
b = c

Finally, return b.

Time Complexity: O(n)
Space Complexity: O(1)

Key Concepts:
- Dynamic Programming
- Fibonacci Pattern
- Iteration
- Constant Space
*/

public class Solution {
    public int ClimbStairs(int n) {
        if (n<=2) return n;
        int a=1;
        int b=2;
        for (int i = 3;i <= n;i++){
            int c= a+b;
            a=b;
            b=c;
        }
        return b;


    }
}
