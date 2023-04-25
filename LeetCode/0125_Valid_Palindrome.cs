using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
    // it reads the same forward and backward.Alphanumeric characters include letters and numbers.
    // Given a string s, return true if it is a palindrome, or false otherwise.

    // Example 1:
    // Input: s = "A man, a plan, a canal: Panama"
    // Output: true
    // Explanation: "amanaplanacanalpanama" is a palindrome.

    // Example 2:
    // Input: s = "race a car"
    // Output: false
    // Explanation: "raceacar" is not a palindrome.

    // Example 3:
    // Input: s = " "
    // Output: true
    // Explanation: s is an empty string "" after removing non-alphanumeric characters.
    // Since an empty string reads the same forward and backward, it is a palindrome.
    #endregion
    internal class _0125_Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s == null) { return true; }
            s = s.ToLower();
            int i = 0;
            int j = s.Length-1;
            while (i<j)
            {
                var left = s[i];
                var right = s[j];
                if (!char.IsLetterOrDigit(left))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetterOrDigit(right))
                {
                    j--;
                    continue;
                }
                if (left != right)
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
