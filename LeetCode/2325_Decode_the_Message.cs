using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You are given the strings key and message, which represent a cipher key and a secret message, respectively.
    // The steps to decode message are as follows:
    // Use the first appearance of all 26 lowercase English letters in key as the order of the substitution table.
    // Align the substitution table with the regular English alphabet.
    // Each letter in message is then substituted using the table.
    // Spaces ' ' are transformed to themselves.

    // For example, given key = "happy boy"(actual key would have at least one instance of each letter in the alphabet),
    // we have the partial substitution table of ('h' -> 'a', 'a' -> 'b', 'p' -> 'c', 'y' -> 'd', 'b' -> 'e', 'o' -> 'f').
    // Return the decoded message.

    // Example 1:
    // Input: key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv"
    // Output: "this is a secret"
    // Explanation: The diagram above shows the substitution table.
    // It is obtained by taking the first appearance of each letter in "the quick brown fox jumps over the lazy dog".

    // Example 2:
    // Input: key = "eljuxhpwnyrdgtqkviszcfmabo", message = "zwx hnfx lqantp mnoeius ycgk vcnjrdb"
    // Output: "the five boxing wizards jump quickly"
    // Explanation: The diagram above shows the substitution table.
    // It is obtained by taking the first appearance of each letter in "eljuxhpwnyrdgtqkviszcfmabo".
    #endregion
    internal class _2325_Decode_the_Message
    {
        public string DecodeMessage(string key, string message)
        {
            Dictionary<char, char> keyMap = new Dictionary<char, char>();
            int counter = 0;
            foreach (char c in key)
            {
                if (c != ' ' && !keyMap.ContainsKey(c))
                {
                    keyMap.Add(c, (char)('a'+ counter));
                    counter++;
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in message)
            {
                if (c == ' ')
                {
                    sb.Append(' ');
                }
                else
                {
                    sb.Append(keyMap[c]);
                }
            }
            return sb.ToString();
        }
    }
}
