using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an array of integers nums, return the number of good pairs.
    // A pair(i, j) is called good if nums[i] == nums[j] and i<j.

    // Example 1:
    // Input: nums = [1, 2, 3, 1, 1, 3]
    // Output: 4
    // Explanation: There are 4 good pairs(0,3), (0,4), (3,4), (2,5) 0-indexed.

    // Example 2:
    // Input: nums = [1,1,1,1]
    // Output: 6
    // Explanation: Each pair in the array are good.

    // Example 3:
    // Input: nums = [1, 2, 3]
    // Output: 0
    #endregion
    internal class _1512_Number_of_Good_Pairs
    {
        public int NumIdenticalPairs_v1(int[] nums)
        {
            int goodPairsCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        goodPairsCount++;
                    }
                }
            }
            return goodPairsCount;
        }
        public int NumIdenticalPairs_v2(int[] nums)
        {
            int goodPairsCount = 0;
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!pairs.ContainsKey(nums[i]))
                {
                    pairs.Add(nums[i], 1);
                }
                else
                {
                    pairs[nums[i]]++;
                }
            }
            foreach (var item in pairs.Values)
            {
                goodPairsCount += item * (item - 1) / 2;
            }
            return goodPairsCount;
        }
        public int NumIdenticalPairs_v3(int[] nums)
        {
            int goodPairsCount = 0;
            HashSet<int> set = new HashSet<int>(nums);
            foreach (var item in set)
            {
                int value = nums.Count(x => x == item);
                goodPairsCount += value * (value - 1) / 2;
            }
            return goodPairsCount;
        }
    }
}
