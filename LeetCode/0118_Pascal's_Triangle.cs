﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0118_Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                List<int> currRow = new List<int>();
                result.Add(currRow);
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        currRow.Add(1);
                    }
                    else
                    {
                        var preRow = result[i - 1];
                        int prePos1 = preRow[j - 1];
                        int prePos2 = preRow[j];
                        currRow.Add(prePos1 + prePos2);
                    }
                }
            }
            return result;
        }
    }
}
