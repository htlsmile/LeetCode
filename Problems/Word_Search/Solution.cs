using System;
using System.Collections.Generic;
using System.Text;

namespace Word_Search
{
    public class Solution
    {
        public bool Exist(char[,] board, string word)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (Exist(board, i, j, word, new List<string>()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Exist(char[,] board, int x, int y, string word, IList<string> l)
        {
            var list = new List<string>(l);
            var str = $"{x.ToString()},{y.ToString()}";
            if (string.IsNullOrEmpty(word))
            {
                return true;
            }
            else if (list.Contains(str)
                || x < 0
                || x > board.GetLength(0) - 1
                || y < 0
                || y > board.GetLength(1) - 1
                || word[0] != board[x, y])
            {
                return false;
            }
            else
            {
                list.Add(str);
                return Exist(board, x - 1, y, word.Remove(0, 1), list)
                    || Exist(board, x + 1, y, word.Remove(0, 1), list)
                    || Exist(board, x, y - 1, word.Remove(0, 1), list)
                    || Exist(board, x, y + 1, word.Remove(0, 1), list);
            }
        }
    }
}
