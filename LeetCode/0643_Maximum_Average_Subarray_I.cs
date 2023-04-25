using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You are given an integer array nums consisting of n elements, and an integer k.
    // Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value.
    // Any answer with a calculation error less than 10-5 will be accepted.

    // Example 1:
    // Input: nums = [1, 12, -5, -6, 50, 3], k = 4
    // Output: 12.75000
    // Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

    // Example 2:
    // Input: nums = [5], k = 1
    // Output: 5.00000
    #endregion
    internal class _0643_Maximum_Average_Subarray_I
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            // Time Limit Exceeded
            double result = int.MinValue;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i <= nums.Length - k; i++)
            {
                int sum = 0;
                for (int j = i; j < k + i; j++)
                {
                    sum += nums[j];
                }
                set.Add(sum);
            }
            foreach (var item in set)
            {
                result = result > item ? result : item;
            }

            return result / k;
        }

        public double FindMaxAverage_V2(int[] nums, int k)
        {
            double result = 0;
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            result = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum += (nums[i] - nums[i - k]);
                result = result > sum ? result : sum;
            }
            return result / k;
        }
    }
}
