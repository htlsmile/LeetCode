using System;

namespace Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] board = { new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 } };
            Test(board);
            Console.ReadKey(true);
        }

        static void Test(int[][] board)
        {
            var solution = new Solution();
            solution.GameOfLife(board);
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    Console.Write(board[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
