using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer array nums, return true if any value appears at least twice in the array,
    // and return false if every element is distinct.

    // Example 1:
    // Input: nums = [1,2,3,1]
    // Output: true
    // 
    // Example 2:
    // Input: nums = [1,2,3,4]
    // Output: false
    // 
    // Example 3:
    // Input: nums = [1,1,1,3,3,4,3,2,4,2]
    // Output: true
    #endregion
    internal class _0217_Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 1)
            {
                return false;
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!set.Add(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
