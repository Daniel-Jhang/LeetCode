using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

    // For example:
    // A -> 1
    // B -> 2
    // C -> 3
    // ...
    // Z -> 26
    // AA -> 27
    // AB -> 28 
    // ...
    #endregion
    internal class _0168_Excel_Sheet_Column_Title
    {
        public string ConvertToTitle(int columnNumber)
        {
            int n = columnNumber;
            StringBuilder sb = new StringBuilder();
            while (n>0)
            {
                n--;
                sb.Append((char)(n % 26 + 'A'));
                n/=26;
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
