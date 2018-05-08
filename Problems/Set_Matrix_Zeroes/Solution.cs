using System;
using System.Collections.Generic;
using System.Text;

namespace Set_Matrix_Zeroes
{
    public class Solution
    {
        /// <summary>
        /// Space:O(1)
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[,] matrix)
        {
            bool f = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (!f && matrix[i, 0] == 0)
                {
                    f = true;
                }
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, 0] = matrix[0, j] = 0;
                    }
                }
            }
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matrix.GetLength(1) - 1; j > 0; j--)
                {
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
                if (f)
                {
                    matrix[i, 0] = 0;
                }
            }
        }

        /// <summary>
        /// Space:O(m+n)
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes_1(int[,] matrix)
        {
            var rows = new List<int>();
            var cols = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (!rows.Contains(i))
                        {
                            rows.Add(i);
                        }
                        if (!cols.Contains(j))
                        {
                            cols.Add(j);
                        }
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Space:O(mn)
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes_2(int[,] matrix)
        {
            var matrix2 = matrix.Clone() as int[,];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    if (matrix2[i, j] == 0)
                    {
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            matrix[k, j] = 0;
                        }
                        for (int k = 0; k < matrix.GetLength(1); k++)
                        {
                            matrix[i, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
