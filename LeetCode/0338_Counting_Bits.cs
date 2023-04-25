using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an integer n, return an array ans of length n + 1 such that for each i(0 <= i <= n),
    // ans[i] is the number of 1's in the binary representation of i.

    // Example 1:
    // Input: n = 2
    // Output: [0,1,1]
    //     Explanation:
    // 0 --> 0
    // 1 --> 1
    // 2 --> 10

    // Example 2:
    // Input: n = 5a
    // Output: [0,1,1,2,1,2]
    //     Explanation:
    // 0 --> 0
    // 1 --> 1
    // 2 --> 10
    // 3 --> 11
    // 4 --> 100
    // 5 --> 101
    #endregion
    internal class _0338_Counting_Bits
    {
        public int[] CountBits_V1(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                result[i] = solve(i, result);
            }
            return result;
        }
        public static int solve(int n, int[] memo)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }

            if (memo[n] != 0) { return memo[n]; }
            if (n % 2 == 0) { return solve(n / 2, memo); }
            else { return 1 + solve(n / 2, memo); }
        }

        public int[] CountBits_V2(int n)
        {
            int[] result = new int[n + 1];
            string binary = "";
            int count;
            for (int i = 0; i <= n; i++)
            {
                count = 0;
                binary = Convert.ToString(i, 2);
                foreach (char bit in binary)
                {
                    if (bit == '1')
                    {
                        count++;
                    }
                    result[i] = count;
                }
            }
            return result;
        }
    }
}
