using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have.
    // Each character in stones is a type of stone you have.You want to know how many of the stones you have are also jewels.
    // Letters are case sensitive, so "a" is considered a different type of stone from "A".

    // Example 1:
    // Input: jewels = "aA", stones = "aAAbbbb"
    // Output: 3

    // Example 2:
    // Input: jewels = "z", stones = "ZZ"
    // Output: 0
    #endregion
    internal class _0771_Jewels_and_Stones
    {
        public int NumJewelsInStones_V1(string jewels, string stones)
        {
            int numberOfJewels = 0;
            for (int i = 0; i < jewels.Length; i++)
            {
                for (int j = 0; j < stones.Length; j++)
                {
                    if (jewels[i] == stones[j])
                    {
                        numberOfJewels++;
                    }
                }
            }
            return numberOfJewels;
        }
        public int NumJewelsInStones_V2(string jewels, string stones)
        {
            int numberOfJewels = 0;
            HashSet<char> jewelsSet = new HashSet<char>(jewels);
            foreach (var item in stones)
            {
                if (jewelsSet.Contains(item))
                {
                    numberOfJewels++;
                }
            }
            return numberOfJewels;
        }
    }
}
