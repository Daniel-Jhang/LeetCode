using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an array nums of size n, return the majority element.
    // The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.

    // Example 1:
    // Input: nums = [3, 2, 3]
    // Output: 3

    // Example 2:
    // Input: nums = [2, 2, 1, 1, 1, 2, 2]
    // Output: 2
    #endregion
    internal class _0169_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int count = 1;
            int majority = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (majority == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        majority = nums[i];
                        count = 1;
                    }
                }
            }
            return majority;
        }
    }
}
