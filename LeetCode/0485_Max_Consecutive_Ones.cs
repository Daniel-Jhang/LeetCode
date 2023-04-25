using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given a binary array nums, return the maximum number of consecutive 1's in the array.

    // Example 1:
    // Input: nums = [1,1,0,1,1,1]
    // Output: 3
    // Explanation: The first two digits or the last three digits are consecutive 1s.The maximum number of consecutive 1s is 3.

    // Example 2:
    // Input: nums = [1,0,1,1,0,1]
    // Output: 2
    #endregion
    internal class _0485_Max_Consecutive_Ones
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else if (nums[i] == 0)
                {
                    count = 0;
                }
                result = count > result ? count : result;
            }

            return result;
        }
    }
}
