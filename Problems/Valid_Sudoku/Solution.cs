using System;
using System.Collections.Generic;
using System.Text;

namespace Valid_Sudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[,] board)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < 9; i++)
            {
                list.Clear();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.' && list.Contains(board[i, j]))
                    {
                        return false;
                    }
                    list.Add(board[i, j]);
                }
                list.Clear();
                for (int j = 0; j < 9; j++)
                {
                    if (board[j, i] != '.' && list.Contains(board[j, i]))
                    {
                        return false;
                    }
                    list.Add(board[j, i]);
                }
            }
            for (int i = 1; i < 9; i += 3)
            {
                for (int j = 1; j < 9; j += 3)
                {
                    list.Clear();
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            if (board[i + x, j + y] != '.' && list.Contains(board[i + x, j + y]))
                            {
                                return false;
                            }
                            list.Add(board[i + x, j + y]);
                        }
                    }
                }
            }
            return true;
        }
    }
}
