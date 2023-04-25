//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    #region Description
//    // Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.
//    // Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.
    
//    // Example 1:
//    // Input: nums = [1, 2, 2, 3, 1]
//    // Output: 2
//    // Explanation: 
//    // The input array has a degree of 2 because both elements 1 and 2 appear twice.
//    // Of the subarrays that have the same degree:
//    // [1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
//    // The shortest length is 2. So return 2.
    
//    // Example 2:
//    // Input: nums = [1, 2, 2, 3, 1, 4, 2]
//    // Output: 6
//    // Explanation: 
//    // The degree is 3 because the element 2 is repeated 3 times.
//    // So[2, 2, 3, 1, 4, 2] is the shortest subarray, therefore returning 6.
//    #endregion
//    internal class _0697_Degree_of_an_Array
//    {
//        public int FindShortestSubArray(int[] nums)
//        {
//            int ans = nums.Length;
//            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (dict.ContainsKey(nums[i]))
//                {
//                    var lst = dict[nums[i]];
//                    lst.Add(i);
//                    dict[nums[i]] = lst;
//                }
//                else
//                {
//                    var lst = new List<int>();
//                    lst.Add(i);
//                    dict.Add(nums[i], lst);
//                }
//            }
//            int degree = dict.OrderByDescending(x => x.Value.Count).First().Value.Count;
//            foreach (var item in dict)
//            {
//                var lst = item.Value;
//                if (lst.Count == degree)
//                {
//                    ans = Math.Min(ans, lst[degree - 1] - lst[0] + 1);
//                }
//            }
//            return ans;
//        }
//    }
//}
