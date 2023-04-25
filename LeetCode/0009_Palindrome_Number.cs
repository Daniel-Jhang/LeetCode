using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0009_Palindrome_Number
    {
        #region Description
        // Given an integer x, return true if x is palindrome(回文) integer.
        // An integer is a palindrome(回文) when it reads the same backward as forward.
        // For example, 121 is a palindrome while 123 is not.

        // Example 1:
        // Input: x = 121
        // Output: true
        // Explanation: 121 reads as 121 from left to right and from right to left.

        // Example 2:
        // Input: x = -121
        // Output: false
        // Explanation: From left to right, it reads - 121.From right to left, it becomes 121 -.Therefore it is not a palindrome.

        // Example 3:
        // Input: x = 10
        // Output: false
        // Explanation: Reads 01 from right to left.Therefore it is not a palindrome.
        #endregion
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) // 排除 -1...(負數)、10, 100...(01不能是10的回文，001不能是100的回文)
            {
                return false;
            }
            if (x < 10) // 1,2,3,...,9 本身就是自己的回文
            {
                return true;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                int remainders = x % 10;
                revertedNumber = revertedNumber * 10 + remainders;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
