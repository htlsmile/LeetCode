using System;

namespace Number_Of_Islands
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] grid1 = {
                { '1', '1', '1', '1', '0' },
                { '1', '1', '0', '1', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '0', '0', '0' }};
            Test(grid1);
            char[,] grid2 = {
                { '1', '1', '0', '0', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '1', '0', '0' },
                { '0', '0', '0', '1', '1' }};
            Test(grid2);
            Console.ReadKey(true);
        }

        static void Test(char[,] grid)
        {
            var solution = new Solution();
            var result = solution.NumIslands(grid);
            Console.WriteLine(result);
        }
    }
}
