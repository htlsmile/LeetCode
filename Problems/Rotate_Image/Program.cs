using System;

namespace Rotate_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Test(matrix1);
            int[,] matrix2 = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };
            Test(matrix2);
            Console.ReadKey(true);
        }

        static void Test(int[,] matrix)
        {
            var solution = new Solution();
            solution.Rotate(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
