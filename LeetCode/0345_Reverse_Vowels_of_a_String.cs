using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given a string s, reverse only all the vowels in the string and return it.
    // The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both cases.

    // Example 1:
    // Input: s = "hello"
    // Output: "holle"

    // Example 2:
    // Input: s = "leetcode"
    // Output: "leotcede"
    #endregion
    internal class _0345_Reverse_Vowels_of_a_String
    {
        public string ReverseVowels(string s)
        {
            HashSet<char> set = new HashSet<char>("AaEeIiOoUu");
            var result = s.ToCharArray();
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (!set.Contains(s[i]))
                {
                    i++;
                }
                else if (!set.Contains(s[j]))
                {
                    j--;
                }
                else
                {
                    var temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                    i++;
                    j--;
                }
            }
            return new string(result);
        }
    }
}
