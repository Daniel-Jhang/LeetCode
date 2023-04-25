using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region Description
    // In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one with a different size r x c keeping its original data.
    // You are given an m x n matrix mat and two integers r and c representing the number of rows and the number of columns of the wanted reshaped matrix.
    // The reshaped matrix should be filled with all the elements of the original matrix in the same row-traversing order as they were.
    // If the reshape operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

    // Example 1:
    // Input: mat = [[1,2],[3,4]], r = 1, c = 4
    // Output: [[1,2,3,4]]

    // Example 2:
    // Input: mat = [[1,2],[3,4]], r = 2, c = 4
    // Output: [[1,2],[3,4]]
    #endregion
    internal class _0566_Reshape_the_Matrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length == 0)
            {
                return mat;
            }
            int m = mat.Length;
            int n = mat[0].Length;
            if (m * n != r * c)
            {
                return mat;
            }

            int[][] answer = new int[r][];
            for (int i = 0; i < r; i++)
            {
                answer[i] = new int[c];
            }
            for (int i = 0; i < m * n; i++)
            {
                int orgX = i % n;
                int orgY = i / n;
                int newX = i % c;
                int newY = i / c;
                answer[newY][newX] = mat[orgY][orgX];
            }

            return answer;
        }

        public int[][] MatrixReshape_V2(int[][] mat, int r, int c)
        {
            if (mat.Length == 0)
            {
                return mat;
            }
            int m = mat.Length;
            int n = mat[0].Length;
            if (m * n != r * c)
            {
                return mat;
            }

            int[][] answer = new int[r][];
            for (int i = 0; i < r; i++)
            {
                answer[i] = new int[c];
            }

            List<int> temp = new List<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp.Add(mat[i][j]);
                }
            }

            int index = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    answer[i][j] = temp[index];
                    index++;
                }
            }

            return answer;
        }

        public int[][] MatrixReshape_V3(int[][] mat, int r, int c)
        {
            if (mat.Length == 0 || ((mat.Length * mat[0].Length) != r*c))
            {
                return mat;
            }

            int matC = mat[0].Length;
            int[][] answer = new int[r][];
            int k = 0;

            for (int i = 0; i < r; i++)
            {
                answer[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    answer[i][j] = mat[k/matC][k%matC];
                    k++;
                }
            }

            return answer;
        }
    }
}
