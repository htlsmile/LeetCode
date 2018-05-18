using System;
using System.Collections.Generic;
using System.Text;

namespace Number_Of_Islands
{
    public class Solution
    {
        public int NumIslands(char[,] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        count++;
                        Expand(ref grid, i, j);
                    }
                }
            }
            return count;
        }

        private void Expand(ref char[,] grid, int x, int y)
        {
            if (x < 0 || x >= grid.GetLength(0) || y < 0 || y >= grid.GetLength(1) || grid[x, y] != '1')
            {
                return;
            }
            grid[x, y] = '0';
            //ShowGrid(grid);
            Expand(ref grid, x - 1, y);
            Expand(ref grid, x + 1, y);
            Expand(ref grid, x, y - 1);
            Expand(ref grid, x, y + 1);
        }

        private void ShowGrid(char[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write($"{grid[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
