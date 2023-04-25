using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.
    // In the American keyboard:
    //   the first row consists of the characters "qwertyuiop",
    //   the second row consists of the characters "asdfghjkl", and
    //   the third row consists of the characters "zxcvbnm".

    // Example 1:
    // Input: words = ["Hello", "Alaska", "Dad", "Peace"]
    // Output: ["Alaska","Dad"]

    // Example 2:
    // Input: words = ["omk"]
    // Output: []

    // Example 3:
    // Input: words = ["adsdf", "sfd"]
    // Output: ["adsdf","sfd"]
    #endregion
    internal class _0500_Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            var firstRow = new HashSet<char>("qwertyuiop".ToCharArray());
            var secondRow = new HashSet<char>("asdfghjkl".ToCharArray());
            var thirdRow = new HashSet<char>("zxcvbnm".ToCharArray());
            var result = new List<string>();
            foreach (var item in words)
            {
                string word = item.ToLower();
                int whichRow;
                bool isValid = true;
                if (firstRow.Contains(word[0]))
                {
                    whichRow = 1;
                }
                else if (secondRow.Contains(word[0]))
                {
                    whichRow = 2;
                }
                else
                {
                    whichRow = 3;
                }

                foreach (var letter in word)
                {
                    if ((whichRow == 1 && !firstRow.Contains(letter))
                   || (whichRow == 2 && !secondRow.Contains(letter))
                   || (whichRow == 3 && !thirdRow.Contains(letter)))
                    {
                        isValid = false;
                    }
                }
                if (isValid == true)
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        public string[] FindWords_V2(string[] words)
        {
            HashSet<char> row1 = new HashSet<char>
        {
            'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'
        };
            HashSet<char> row2 = new HashSet<char>
        {
            'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'
        };
            HashSet<char> row3 = new HashSet<char>
        {
            'z', 'x', 'c', 'v', 'b', 'n', 'm'
        };
            List<string> validWords = new List<string>();
            string word;
            int row;
            bool valid;

            foreach (var w in words)
            {
                word = w.ToLower();
                valid = true;

                if (row1.Contains(word[0])) { row = 1; }
                else if (row2.Contains(word[0])) { row = 2; }
                else { row = 3; }

                foreach (var letter in word)
                {
                    if ((row == 1 && !row1.Contains(letter))
                       || (row == 2 && !row2.Contains(letter))
                       || (row == 3 && !row3.Contains(letter)))
                        valid = false;
                }
                if (valid)
                    validWords.Add(w);
            }

            return validWords.ToArray();
        }
    }
}
