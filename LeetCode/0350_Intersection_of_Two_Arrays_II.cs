using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given two integer arrays nums1 and nums2, return an array of their intersection.
    // Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

    // Example 1:
    // Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
    // Output: [2,2]

    // Example 2:
    // Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
    // Output: [4,9]
    // Explanation: [9,4] is also accepted.
    #endregion
    internal class _0350_Intersection_of_Two_Arrays_II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return Intersect(nums2, nums1);
            }
            Dictionary<int, int> nums1Map = new Dictionary<int, int>();
            List<int> result = new List<int>();
            foreach (var item in nums1)
            {
                if (!nums1Map.ContainsKey(item))
                {
                    nums1Map.Add(item, 1);
                }
                else
                {
                    nums1Map[item]++;
                }
            }
            foreach (var item in nums2)
            {
                if (nums1Map.ContainsKey(item))
                {
                    if (nums1Map[item] > 1)
                    {
                        result.Add(item);
                        nums1Map[item]--;
                    }
                    else
                    {
                        result.Add(item);
                        nums1Map.Remove(item);
                    }
                }
            }
            return result.ToArray();
        }

        public int[] Intersect_V2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                } else if (nums1[i] > nums2[j])
                {
                    j++;
                } else if (nums1[i] < nums2[j])
                {
                    i++;
                }
            }

            return result.ToArray();
        }
    }
}
