using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0088_Merge_Sorted_Array
    {
        public void Merge_V1(int[] nums1, int m, int[] nums2, int n)
        {
            // 暴力解
            for (int i = 0; i < n - 1; i++) // 先把nums2的值全部塞到nums1的後半部
            {
                nums1[m + n] = nums2[i];
            }
            Array.Sort(nums1); // 直接呼叫內建的函式
        }

        // 參考: https://www.youtube.com/watch?v=KkmV7Uuosmc&ab_channel=%E5%B1%B1%E6%99%AF%E5%9F%8E%E4%B8%80%E5%A7%90
        public void Merge_V2(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[k] = nums1[i];
                    k--;
                    i--;
                }
                else if (nums1[i] < nums2[j])
                {
                    nums1[k] = nums2[j];
                    k--;
                    j--;
                }
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                k--;
                j--;
            }
        }
    }
}
