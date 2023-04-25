using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given two binary strings a and b, return their sum as a binary string.

    // Example 1:
    // Input: a = "11", b = "1"
    // Output: "100"

    // Example 2:
    // Input: a = "1010", b = "1011"
    // Output: "10101"
    #endregion
    internal class _0067_Add_Binary
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0;
            int value = 0;
            int length = Math.Max(a.Length, b.Length);
            for (int i = 0; i < length; i++)
            {
                value = carry;
                if (i < a.Length)
                {
                    value += Convert.ToInt32(a[a.Length - 1 - i] - '0');
                }
                if (i < b.Length)
                {
                    value += Convert.ToInt32(b[b.Length - 1 - i] - '0');
                }
                carry = value / 2;
                value = value % 2;
                result.Insert(0, value);
            }
            if (carry > 0)
            {
                result.Insert(0, 1);
            }
            return result.ToString();
        }
    }
}
