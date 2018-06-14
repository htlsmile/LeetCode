using System;
using System.Collections.Generic;
using System.Text;

namespace Spiral_Matrix
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var result = new List<int>();
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            var visited = new bool[row, col];
            var direction = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
            int r = 0, c = 0, index = 0;
            for (int count = 0; count < visited.Length; count++)
            {
                result.Add(matrix[r, c]);
                visited[r, c] = true;
                r += direction[index, 0];
                c += direction[index, 1];
                if (!(r >= 0 && r < row && c >= 0 && c < col && !visited[r, c]))
                {
                    r -= direction[index, 0];
                    c -= direction[index, 1];
                    index = (index + 1) % 4;
                    r += direction[index, 0];
                    c += direction[index, 1];
                }
            }
            return result;
        }
    }
}
