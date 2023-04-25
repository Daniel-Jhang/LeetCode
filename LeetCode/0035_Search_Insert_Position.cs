using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0035_Search_Insert_Position
    {
        #region Description
        // Given a sorted array of distinct integers and a target value, return the index if the target is found.
        // If not, return the index where it would be if it were inserted in order.
        // You must write an algorithm with O(log n) runtime complexity.

        // Example 1:
        // Input: nums = [1, 3, 5, 6], target = 5
        // Output: 2

        // Example 2:
        // Input: nums = [1, 3, 5, 6], target = 2
        // Output: 1

        // Example 3:
        // Input: nums = [1, 3, 5, 6], target = 7
        // Output: 4
        #endregion
        public int SearchInsert(int[] nums, int target)
        {
            // sorted array + O(log n) ==> Binary search
            if (target < nums[0])
            {
                return 0;
            }
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }

            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
            }

            return low;
        }

        public int SearchInsert_V2(int[] nums, int target)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    index = i;
                }
                else if (nums[i] < target)
                {
                    index = i + 1;
                }
            }
            return index;
        }
    }
}
