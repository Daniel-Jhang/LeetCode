using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.
    // Grid cells are connected horizontally/vertically (not diagonally).
    // The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).
    // The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island.
    // One cell is a square with side length 1.
    // The grid is rectangular, width and height don't exceed 100.
    // Determine the perimeter of the island.

    // [[0,1,0,0],
    //  [1,1,1,0],
    //  [0,1,0,0],
    //  [1,1,0,0]]

    // Input: grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
    // Output: 16
    // Explanation: The perimeter is the 16 yellow stripes in the image above.
    #endregion
    internal class _0463_Island_Perimeter
    {
        public int IslandPerimeter(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            int length = grid.Length;
            int width = grid[0].Length;
            int area = 0;
            int neighbor = 0;
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    if (grid[x][y]==1)
                    {
                        area++;

                        if (x<length-1 && grid[x + 1][y]==1)
                        {
                            neighbor++;
                        }
                        if (x>0 && grid[x - 1][y]==1)
                        {
                            neighbor++;
                        }
                        if (y<width-1 && grid[x][y+1] == 1)
                        {
                            neighbor++;
                        }
                        if (y>0 && grid[x][y-1] == 1)
                        {
                            neighbor++;
                        }
                    }
                }
            }

            return area * 4 - neighbor;
        }
    }
}
