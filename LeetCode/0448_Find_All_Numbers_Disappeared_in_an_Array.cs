using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an array nums of n integers where nums[i] is in the range[1, n],
    // return an array of all the integers in the range[1, n] that do not appear in nums.

    // Example 1:
    // Input: nums = [4,3,2,7,8,2,3,1]
    // Output: [5,6]

    // Example 2:
    // Input: nums = [1,1]
    // Output: [2]
    #endregion
    internal class _0448_Find_All_Numbers_Disappeared_in_an_Array
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                dic.Add(i, i);
            }
            int n = nums.Length;
            foreach (int i in dic.Values)
            {
                if (!nums.Contains(i))
                {
                    result.Add(dic[i]);
                }
            }
            return result;
        }

        public IList<int> FindDisappearedNumbers_V2(int[] nums)
        {
            List<int> result = new List<int>();
            HashSet<int> a = new HashSet<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                a.Add(i);
            }
            HashSet<int> b = new HashSet<int>();
            foreach (int i in nums)
            {
                b.Add(i);
            }
            var temp = a.Except(b);
            foreach (var item in temp)
            {
                result.Add(item);
            }
            return result;
        }

        public IList<int> FindDisappearedNumbers_V3(int[] nums)
        {
            bool[] values = new bool[nums.Length + 1];
            List<int> result = new List<int>();
            foreach (int item in nums)
            {
                values[item] = true;
            }
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == false)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public IList<int> FindDisappearedNumbers_V4(int[] nums)
        {
            var li = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) nums[index] *= -1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) li.Add(i + 1);
            }
            return li;
        }
    }
}
