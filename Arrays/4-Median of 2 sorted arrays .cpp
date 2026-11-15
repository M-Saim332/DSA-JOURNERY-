/*
Problem Name: Median of Two Sorted Arrays
LeetCode: 4

Problem:
Given two sorted integer arrays A and B, find the median
of the two sorted arrays.

The overall time complexity should ideally be O(log(m + n)),
but this solution uses a sorting-based approach.

Approach:
First, calculate the sizes of both arrays.

Append all elements of the second array B into the first
array A using push_back().

Then, use sort() to sort the combined array in ascending order.

Calculate the total number of elements.

If the total size is even:
    Find the two middle elements and calculate their average.

If the total size is odd:
    Return the middle element directly.

For even-sized arrays, divide by 2.0 to ensure floating-point
division instead of integer division.

Finally, return the median.

Time Complexity: O((m + n) log(m + n))
Space Complexity: O(1) auxiliary space
                  (excluding sorting implementation details)

Key Concepts:
- Array Manipulation
- STL sort()
- Median Calculation
- Even and Odd Length
- Indexing
- Floating-Point Division
*/

class Solution {
public:
    double findMedianSortedArrays(vector<int>& A, vector<int>& B) {

        int m = A.size();
        int n = B.size();

        for (int i = 0; i < n; i++) {
            A.push_back(B[i]);
        }
        sort(A.begin(), A.end());
        int total = A.size();
        if (total % 2 == 0) {
            return (A[total/2 - 1] + A[total/2]) / 2.0;
        }
        else {
            return A[total/2];
        }
    }
};
