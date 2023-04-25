using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer array nums, find three numbers whose product is maximum and return the maximum product.

    // Example 1:
    // Input: nums = [1,2,3]
    // Output: 6

    // Example 2:
    // Input: nums = [1,2,3,4]
    // Output: 24

    // Example 3:
    // Input: nums = [-1,-2,-3]
    // Output: -6
    #endregion
    internal class _0628_Maximum_Product_of_Three_Numbers
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums); // -100, -98, -1, 2, 3, 4
            int len = nums.Length;
            int possibility1 = nums[0] * nums[1] * nums[len - 1];
            int possibility2 = nums[len - 1] * nums[len - 2] * nums[len - 3];
            return possibility1 > possibility2 ? possibility1 : possibility2;
        }
    }
}
