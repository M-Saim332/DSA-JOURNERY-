/*
Problem Name: Valid Palindrome
LeetCode: 125

Problem:
Given a string, determine whether it is a palindrome after
converting all uppercase letters to lowercase and removing
all non-alphanumeric characters.

A palindrome reads the same forward and backward.

Approach:
Use the Two-Pointer technique with one pointer at the
beginning and the other at the end of the string.

1. Use IsAlphanumeric() to check whether a character is a
   letter or digit.
2. If the left character is not alphanumeric, move st forward.
3. If the right character is not alphanumeric, move end backward.
4. Convert both characters to lowercase and compare them.
5. If they differ, return false.
6. If they match, move both pointers toward the center.
7. If all valid characters match, return true.

Time Complexity: O(n)
Space Complexity: O(1)

Key Concepts:
- Two-Pointer Technique
- String Manipulation
- Character Validation
- Case-Insensitive Comparison
- Character Filtering
*/

public class Solution
{
    public bool IsAlphanumeric(char c)
    {
        c = char.ToLower(c);

        if ((c >= '0' && c <= '9') ||
            (c >= 'a' && c <= 'z'))
        {
            return true;
        }

        return false;
    }

    public bool IsPalindrome(string s)
    {
        int st = 0;
        int end = s.Length - 1;

        while (st <= end)
        {
            if (!IsAlphanumeric(s[st]))
            {
                st++;
                continue;
            }

            if (!IsAlphanumeric(s[end]))
            {
                end--;
                continue;
            }

            if (char.ToLower(s[st]) != char.ToLower(s[end]))
            {
                return false;
            }

            st++;
            end--;
        }

        return true;
    }
}
