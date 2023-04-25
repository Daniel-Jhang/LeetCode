using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0069_Sqrt_x_
    {
        #region Description
        // Given a non-negative integer x, compute and return the square root of x.
        // Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.
        // Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.

        // Example 1:
        // Input: x = 4
        // Output: 2

        // Example 2:
        // Input: x = 8
        // Output: 2
        // Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
        #endregion
        // Brute force暴力解
        public int MySqrt(int x)
        {
            if (x <= 1) // 如果Input = 0
            {
                return x;
            }

            // 假設Input = 12 (12的平方根是 3.4641...)，則 i = 4(4*4>12)，因為只需要回傳整數部分，所以回傳 i -1 即可
            for (long i = 1; i <= x; i++) // 暴力解，所有數字檢查一次
            {
                if (i * i > x) // eg. 檢查 1*1, 2*2, 3*3,...是否大於x，直到找到 i*i > x
                {
                    return (int)i - 1;
                }
            }
            throw new Exception("NOT FOUND");
        }

        // Binary Search
        public int MySqrt_V2(int x)
        {
            if (x < 2)
            {
                return x;
            }

            // 假設Input = 12 (12的平方根是 3.4641...)
            int left = 1;
            int right = x / 2;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (mid > x / mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return (left - 1);
        }
    }
}
