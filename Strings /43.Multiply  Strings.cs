/*
Problem Name: Multiply Strings
LeetCode: 43

Problem:
Given two non-negative integers represented as strings, return
their product as a string.

The numbers can be very large, so we cannot directly convert
them into integers and use normal multiplication.

Approach:
Use the same idea as traditional multiplication.

Create an integer array of size m + n to store the result,
where m and n are the lengths of the two input strings.

Traverse both strings from right to left:
1. Convert each character into a digit.
2. Multiply the two digits.
3. Calculate the positions where the product and carry
   should be stored using p1 and p2.
4. Add the product to the existing value at p2.
5. Store the last digit using sum % 10.
6. Store the carry using sum / 10.

After multiplication, traverse the result array and skip
leading zeros to build the final result string.

Time Complexity: O(m * n)
Space Complexity: O(m + n)

Key Concepts:
- String Manipulation
- Array
- Digit-by-Digit Multiplication
- Carry Handling
- Character to Integer Conversion
*/
public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        int m = num1.Length;
        int n = num2.Length;

        int[] ans = new int[m + n];

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int dig1 = num1[i] - '0';
                int dig2 = num2[j] - '0';

                int product = dig1 * dig2;

                int p1 = i + j;
                int p2 = i + j + 1;

                int sum = product + ans[p2];

                ans[p2] = sum % 10;
                ans[p1] += sum / 10;
            }
        }

        string result = "";

        foreach (int digit in ans)
        {
            if (result.Length == 0 && digit == 0)
            {
                continue;
            }

            result += digit.ToString();
        }

        return result;
    }
}
