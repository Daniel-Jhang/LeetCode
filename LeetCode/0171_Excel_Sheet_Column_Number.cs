using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

    // For example:
    // A -> 1
    // B -> 2
    // C -> 3
    // ...
    // Z -> 26
    // AA -> 27
    // AB -> 28 
    // ...

    // Example 1:
    // Input: columnTitle = "A"
    // Output: 1

    // Example 2:
    // Input: columnTitle = "AB"
    // Output: 28

    // Example 3:
    // Input: columnTitle = "ZY"
    // Output: 701
    #endregion
    internal class _0171_Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string columnTitle)
        {
            // https://www.youtube.com/watch?v=0nzg5-CDCYs&ab_channel=Michelle%E5%B0%8F%E6%A2%A6%E6%83%B3%E5%AE%B6
            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                result = result * 26 + columnTitle[i] - 'A' + 1;
            }

            return result;
        }
    }
}
