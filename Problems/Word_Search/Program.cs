using System;

namespace Word_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = {
                { 'A', 'B', 'C', 'E' },
                { 'S', 'F', 'C', 'S' },
                { 'A', 'D', 'E', 'E' } };
            Test(board, "ABCCED");
            Test(board, "SEE");
            Test(board, "ABCB");
            Console.ReadKey(true);
        }

        static void Test(char[,] board, string word)
        {
            var solution = new Solution();
            var result = solution.Exist(board, word);
            Console.WriteLine(result);
        }
    }
}
