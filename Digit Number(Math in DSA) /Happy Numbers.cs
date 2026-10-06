/*
Problem Name: Happy Number
LeetCode: 202

Problem:
A happy number is a number that eventually reaches 1 when
replaced repeatedly by the sum of the squares of its digits.

If the process enters a cycle that does not include 1,
the number is not happy.

Approach:
Use a HashSet to keep track of numbers that have already
appeared.

For each number:
1. Calculate the sum of the squares of its digits.
2. Replace n with this calculated sum.
3. If n becomes 1, return true.
4. If n appears again in the HashSet, a cycle has been
   detected, so return false.
5. Otherwise, add n to the HashSet and continue.

The SumOfSquares() function extracts each digit using
n % 10, squares it, adds it to the sum, and removes the
last digit using n / 10.

Time Complexity: O(log n) approximately
Space Complexity: O(log n)

Key Concepts:
- HashSet
- Cycle Detection
- Digit Extraction
- Modulo Operator
- Integer Division
*/
public class Solution
{
    public int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n = n / 10;
        }

        return sum;
    }

    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1)
        {
            if (seen.Contains(n))
            {
                return false;
            }

            seen.Add(n);

            n = SumOfSquares(n);
        }

        return true;
    }
}
