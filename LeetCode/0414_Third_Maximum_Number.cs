using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer array nums, return the third distinct maximum number in this array.
    // If the third maximum does not exist, return the maximum number.

    // Example 1:
    // Input: nums = [3, 2, 1]
    // Output: 1
    // Explanation:
    // The first distinct maximum is 3.
    // The second distinct maximum is 2.
    // The third distinct maximum is 1.

    // Example 2:
    // Input: nums = [1, 2]
    // Output: 2
    // Explanation:
    // The first distinct maximum is 2.
    // The second distinct maximum is 1.
    // The third distinct maximum does not exist, so the maximum (2) is returned instead.

    // Example 3:
    // Input: nums = [2,2,3,1]
    // Output: 1
    // Explanation:
    // The first distinct maximum is 3.
    // The second distinct maximum is 2 (both 2's are counted together since they have the same value).
    // The third distinct maximum is 1.
    #endregion
    internal class _0414_Third_Maximum_Number
    {
        public int ThirdMax(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums[0];
            }
            int firstMax = nums[0];
            double secondMax = double.NegativeInfinity;
            double thirdMax = double.NegativeInfinity;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = nums[i];
                }
                else if (nums[i] > secondMax && nums[i] < firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = nums[i];
                }
                else if (nums[i] > thirdMax && nums[i] < secondMax)
                {
                    thirdMax = nums[i];
                }
            }
            return (int)(thirdMax == double.NegativeInfinity ? firstMax : thirdMax);
        }
    }
}
