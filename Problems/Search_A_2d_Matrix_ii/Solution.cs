using System;
using System.Collections.Generic;
using System.Text;

namespace Search_A_2d_Matrix_ii
{
    public class Solution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int x = 0;
            int y = matrix.GetLength(1) - 1;
            while (x < matrix.GetLength(0) && y >= 0)
            {
                if (matrix[x, y] == target)
                {
                    return true;
                }
                else if (matrix[x, y] < target)
                {
                    x++;
                }
                else
                {
                    y--;
                }
            }
            return false;
        }
    }
}
