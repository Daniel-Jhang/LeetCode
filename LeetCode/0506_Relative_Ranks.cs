using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition.
    // All the scores are guaranteed to be unique.
    // The athletes are placed based on their scores, where the 1st place athlete has the highest score,
    // the 2nd place athlete has the 2nd highest score, and so on.
    // The placement of each athlete determines their rank:

    // The 1st place athlete's rank is "Gold Medal".
    // The 2nd place athlete's rank is "Silver Medal".
    // The 3rd place athlete's rank is "Bronze Medal".
    // For the 4th place to the nth place athlete, their rank is their placement number (i.e., the xth place athlete's rank is "x").
    // Return an array answer of size n where answer[i] is the rank of the ith athlete.

    // Example 1:
    // Input: score = [5, 4, 3, 2, 1]
    // Output: ["Gold Medal","Silver Medal","Bronze Medal","4","5"]
    // Explanation: The placements are[1st, 2nd, 3rd, 4th, 5th].

    // Example 2:
    // Input: score = [10, 3, 8, 9, 4]
    // Output: ["Gold Medal","5","Bronze Medal","Silver Medal","4"]
    // Explanation: The placements are[1st, 5th, 3rd, 2nd, 4th].
    #endregion
    internal class _0506_Relative_Ranks
    {
        public string[] FindRelativeRanks(int[] score)
        {
            string[] answer = new string[score.Length];

            int[] ranks = new int[score.Length];
            score.CopyTo(ranks, 0);
            Array.Sort(ranks);
            Array.Reverse(ranks);

            Dictionary<int, string> rankMap = new Dictionary<int, string>();
            for (int i = 0; i < ranks.Length; i++)
            {
                string value = "";
                switch (i)
                {
                    case 0:
                        value = "Gold Medal";
                        break;
                    case 1:
                        value = "Silver Medal";
                        break;
                    case 2:
                        value = "Bronze Medal";
                        break;
                    default:
                        value = (i + 1).ToString();
                        break;
                }
                rankMap.Add(ranks[i], value);
            }

            for (int i = 0; i < score.Length; i++)
            {
                answer[i] = rankMap[score[i]];
            }

            return answer;
        }
    }
}
