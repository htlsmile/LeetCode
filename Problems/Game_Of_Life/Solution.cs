using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Of_Life
{
    public class Solution
    {
        public void GameOfLife(int[][] board)
        {
            if (board == null || board.Length == 0) return;
            int m = board.Length, n = board[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int lives = LiveNeighbors(board, m, n, i, j);

                    // In the beginning, every 2nd bit is 0;
                    // So we only need to care about when will the 2nd bit become 1.
                    if (board[i][j] == 1 && lives >= 2 && lives <= 3)
                    {
                        board[i][j] = 3; // Make the 2nd bit 1: 01 ---> 11
                    }
                    if (board[i][j] == 0 && lives == 3)
                    {
                        board[i][j] = 2; // Make the 2nd bit 1: 00 ---> 10
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i][j] >>= 1;  // Get the 2nd state.
                }
            }
        }

        public int LiveNeighbors(int[][] board, int m, int n, int i, int j)
        {
            int lives = 0;
            for (int x = Math.Max(i - 1, 0); x <= Math.Min(i + 1, m - 1); x++)
            {
                for (int y = Math.Max(j - 1, 0); y <= Math.Min(j + 1, n - 1); y++)
                {
                    lives += board[x][y] & 1;
                }
            }
            lives -= board[i][j] & 1;
            return lives;
        }
    }
}
