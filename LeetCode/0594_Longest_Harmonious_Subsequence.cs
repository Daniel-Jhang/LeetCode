using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.
    // Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.
    // A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order of the remaining elements.

    // Example 1:
    // Input: nums = [1, 3, 2, 2, 5, 2, 3, 7]
    // Output: 5
    // Explanation: The longest harmonious subsequence is [3,2,2,2,3].

    // Example 2:
    // Input: nums = [1, 2, 3, 4]
    // Output: 2

    // Example 3:
    // Input: nums = [1, 1, 1, 1]
    // Output: 0
    #endregion
    internal class _0594_Longest_Harmonious_Subsequence
    {
        public int FindLHS(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int result = 0;
            Dictionary<int, int> numsMap = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (numsMap.ContainsKey(item))
                {
                    numsMap[item]++;
                }
                else
                {
                    numsMap.Add(item, 1);
                }
            }
            foreach (var item in numsMap)
            {
                if (numsMap.ContainsKey(item.Key + 1))
                {
                    result = result > (item.Value + numsMap[item.Key + 1]) ? result : (item.Value + numsMap[item.Key + 1]);
                }
            }
            return result;
        }
    }
}
