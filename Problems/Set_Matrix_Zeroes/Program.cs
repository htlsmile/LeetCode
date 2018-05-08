using System;

namespace Set_Matrix_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            Test(m1);
            int[,] m2 = { { 0, 1, 2, 0 }, { 3, 4, 5, 2 }, { 1, 3, 1, 5 } };
            Test(m2);
            Console.ReadKey(true);
        }

        static void Test(int[,] matrix)
        {
            var solution = new Solution();
            solution.SetZeroes(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
