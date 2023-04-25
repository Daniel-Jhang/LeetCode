using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    // Note that you must do this in-place without making a copy of the array.

    // Example 1:
    // Input: nums = [0, 1, 0, 3, 12]
    // Output: [1,3,12,0,0]

    // Example 2:
    // Input: nums = [0]
    // Output: [0]
    #endregion
    internal class _0283_Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length > 1)
            {
                int index = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[index++] = nums[i];
                    }
                }
                for (int i = index; i < nums.Length; i++)
                {
                    nums[i] = 0;
                }
            }
        }

        public void MoveZeroes_V2(int[] nums)
        {
            if (nums.Length > 1)
            {
                int index = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        int temp = nums[i];
                        nums[i] = nums[index];
                        nums[index++] = temp;
                    }
                }
            }
        }
    }
}
