using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

    // Example 1:
    // Input: nums = [1,2,3,1], k = 3
    // Output: true

    // Example 2:
    // Input: nums = [1,0,1,1], k = 1
    // Output: true

    // Example 3:
    // Input: nums = [1,2,3,1,2,3], k = 2
    // Output: false
    #endregion
    internal class _0219_Contains_Duplicate_II
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]) && i - dic[nums[i]] <= k)
                {
                    return true;
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
