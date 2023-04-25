using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You are given an m x n matrix M initialized with all 0's and an array of operations ops,
    // where ops[i] = [ai, bi] means M[x][y] should be incremented by one for all 0 <= x < ai and 0 <= y < bi.
    // Count and return the number of maximum integers in the matrix after performing all the operations.

    // Example 1:
    // Input: m = 3, n = 3, ops = [[2,2],[3,3]]
    // Output: 4
    // Explanation: The maximum integer in M is 2, and there are four of it in M.So return 4.

    // Example 2:
    // Input: m = 3, n = 3, ops = [[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3]]
    // Output: 4

    // Example 3:
    // Input: m = 3, n = 3, ops = []
    // Output: 9
    #endregion
    internal class _0598_Range_Addition_II
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            int minRow = m;
            int minCol = n;
            foreach (int[] item in ops)
            {
                //minRow = minRow < item[0] ? minRow : item[0];
                minRow = Math.Min(minRow, item[0]);
                //minCol = minCol < item[1] ? minCol : item[1];
                minCol = Math.Min(minCol, item[1]);
            }
            return minRow * minCol;
        }
    }
}
