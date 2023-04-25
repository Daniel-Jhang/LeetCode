using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You are climbing a staircase.It takes n steps to reach the top.
    // Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

    // Example 1:
    // Input: n = 2
    // Output: 2
    // Explanation: There are two ways to climb to the top.
    // 1. 1 step + 1 step
    // 2. 2 steps

    // Example 2:
    // Input: n = 3
    // Output: 3
    // Explanation: There are three ways to climb to the top.
    // 1. 1 step + 1 step + 1 step
    // 2. 1 step + 2 steps
    // 3. 2 steps + 1 step
    #endregion
    internal class _0070_Climbing_Stairs
    {
        // 參考: https://www.youtube.com/watch?v=Y0lT9Fck7qI&ab_channel=NeetCode
        public int ClimbStairs(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int one = 1;
            int two = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int temp = one;
                one = one + two;
                two = temp;
            }
            return one;
        }

        public int ClimbStairs_V2(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int[] map = new int[n];
            map[0] = 1;
            map[1] = 2;
            for (int i = 2; i < n; i++)
            {
                map[i] = map[i - 1] + map[i - 2];
            }
            return map[n - 1];
        }
    }
}
