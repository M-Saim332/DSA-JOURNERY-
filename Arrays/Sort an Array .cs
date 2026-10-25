/*
Problem Name: Sort an Array
LeetCode: 912

Problem:
Given an integer array nums, sort the array in ascending
order and return the sorted array.

Approach:
Use the Merge Sort algorithm, which follows the
Divide and Conquer technique.

1. Divide:
   Find the middle index and divide the array into two halves.

2. Recursively Sort:
   Call Sort() on the left half and the right half until
   each subarray contains only one element.

3. Merge:
   Use two pointers to compare elements from both sorted
   halves. Add the smaller element to a temporary list.
   Copy any remaining elements from either half into the list.

4. Copy Back:
   Copy the sorted elements from the temporary list back
   into the original array, starting at index st.

Finally, return the sorted array.

Time Complexity: O(n log n)
Space Complexity: O(n)

Key Concepts:
- Merge Sort
- Divide and Conquer
- Recursion
- Two-Pointer Technique
- Temporary Array/List
- In-Place Array Updating
*/


public class Solution
{
    void merge(int[] nums, int st, int end, int mid)
    {
        int i = st;
        int j = mid + 1;
        List<int> temp = new List<int>();
        while (i <= mid && j <= end)
        {
            if (nums[i] <= nums[j])
            {
                temp.Add(nums[i]);
                i++;
            }
            else
            {
                temp.Add(nums[j]);
                j++;
            }
        }
        while (i <= mid)
        {
            temp.Add(nums[i]);
            i++;
        }
        while (j <= end)
        {
            temp.Add(nums[j]);
            j++;
        }
        for (int k = 0; k < temp.Count; k++)
        {
            nums[st + k] = temp[k];
        }
    }
    void Sort(int[] nums, int st, int end)
    {
        if (st >= end)
        {
            return;
        }
        int mid = st + (end - st) / 2;
        Sort(nums, st, mid);
        Sort(nums, mid + 1, end);
        merge(nums, st, end, mid);
    }
    public int[] SortArray(int[] nums)
    {
        Sort(nums, 0, nums.Length - 1);
        return nums;
    }

}
