using System;

namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Test(matrix1);
            int[,] matrix2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            Test(matrix2);
            Console.ReadKey(true);
        }

        static void Test(int[,] matrix)
        {
            var solution = new Solution();
            var result = solution.SpiralOrder(matrix);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.WriteLine();
        }
    }
}
