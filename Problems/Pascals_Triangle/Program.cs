using System;

namespace Pascals_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var numRows = 5;
            Test(numRows);
            Console.ReadKey(true);
        }

        static void Test(int numRows)
        {
            var solution = new Solution();
            var result = solution.Generate(numRows);
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.Write($"{result[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
