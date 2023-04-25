using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0001_Two_Sum
    {
        #region Description
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.

        // Example 1:
        // Input: nums = [2, 7, 11, 15], target = 9
        // Output: [0,1]
        // Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

        // Example 2:
        // Input: nums = [3, 2, 4], target = 6
        // Output: [1,2]

        // Example 3:
        // Input: nums = [3, 3], target = 6
        // Output: [0,1]
        #endregion
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            // hashTable最終可能長這個樣子
            // Input: nums = [2, 7, 11, 15], target = 9
            // Key(Input array 的 Value)   Value(Input array 的 Index)
            // 2                                        0
            // 7                                        1
            // 11                                       2
            // 15                                       3

            for (int i = 0; i < nums.Length; i++) // 走訪整個Array
            {
                int complement = target - nums[i]; // A(即nums[i]) + B = target，反之 B(complement) = target - A
                if (hashTable.ContainsKey(complement)) // 接著到hashTable找B(complement)
                {
                    return new int[] { hashTable[complement], i }; // 若是找到complement則回傳hashTable對應的value和 i值
                }
                else
                {
                    hashTable[nums[i]] = i; // 若是hashTable裡沒有B(complement)則將當前A(即nums[i])存入hashTable
                }
            }
            throw new Exception("Not Found");
        }
    }
}
