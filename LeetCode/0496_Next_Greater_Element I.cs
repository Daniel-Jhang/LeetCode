using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.
    // You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.
    // For each 0 <= i<nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2.
    // If there is no next greater element, then the answer for this query is -1.
    // Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.

    // Example 1:
    // Input: nums1 = [4, 1, 2], nums2 = [1, 3, 4, 2]
    // Output: [-1,3,-1]
    // Explanation: The next greater element for each value of nums1 is as follows:
    // - 4 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
    // - 1 is underlined in nums2 = [1, 3, 4, 2].The next greater element is 3.
    // - 2 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.

    // Example 2:
    // Input: nums1 = [2, 4], nums2 = [1, 2, 3, 4]
    // Output: [3,-1]
    // Explanation: The next greater element for each value of nums1 is as follows:
    // - 2 is underlined in nums2 = [1, 2, 3, 4].The next greater element is 3.
    // - 4 is underlined in nums2 = [1, 2, 3, 4].There is no next greater element, so the answer is -1.
    #endregion
    internal class _0496_Next_Greater_Element_I
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var map = new Dictionary<int, int>(); // 存放從stack找到的next greater elements
            var stack = new Stack<int>(); // monotonic stack
            var result = new int[nums1.Length];

            // 利用 monotonic stack 走訪 nums2 array 找出 nums2 個別 element 的 next greater numbers
            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Any() && stack.Peek() < nums2[i]) // 當 stack 不為空，且 stack 當前最 top 的值小於 nums[i] 時
                {
                    map[stack.Peek()] = nums2[i]; 
                    stack.Pop();
                }
                stack.Push(nums2[i]);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (map.ContainsKey(nums1[i]))
                {
                    result[i] = map[nums1[i]];
                }
                else
                {
                    result[i] = -1;
                }
            }

            return result;
        }
    }
}
