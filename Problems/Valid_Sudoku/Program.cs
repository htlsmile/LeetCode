using System;

namespace Valid_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = {
                {'5','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','.'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'}};
            Test(board);
            Console.ReadKey(true);
        }

        static void Test(char[,] board)
        {
            var solution = new Solution();
            var result = solution.IsValidSudoku(board);
            Console.WriteLine(result);
        }
    }
}
