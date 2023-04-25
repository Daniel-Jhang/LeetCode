using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You have a set of integers s, which originally contains all the numbers from 1 to n.
    // Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set,
    // which results in repetition of one number and loss of another number.
    // You are given an integer array nums representing the data status of this set after the error.
    // Find the number that occurs twice and the number that is missing and return them in the form of an array.

    // Example 1:
    // Input: nums = [1, 2, 2, 4]
    // Output: [2,3]

    // Example 2:
    // Input: nums = [1, 1]
    // Output: [1,2]
    #endregion
    internal class _0645_Set_Mismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int duplication = 0;
            int missing = 0;
            int numsSum = 0;
            HashSet<int> numsSet = new HashSet<int>();
            foreach (var item in nums)
            {
                if (numsSet.Contains(item))
                {
                    duplication = item;
                }
                else
                {
                    numsSet.Add(item);
                    numsSum += item;
                }
            }
            int sum = (1 + nums.Length) * nums.Length / 2; // 1+2+3+...+100的公式 => (1+100) * 100 / 2
            missing = sum - numsSum;

            return new int[2] { duplication, missing};
        }
    }
}
