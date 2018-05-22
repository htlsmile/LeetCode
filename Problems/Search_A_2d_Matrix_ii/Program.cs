using System;

namespace Search_A_2d_Matrix_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 4, 7, 11, 15},
                {2, 5, 8, 12, 19},
                {3, 6, 9, 16, 22},
                {10, 13, 14, 17, 24},
                {18, 21, 23, 26, 30}};
            Test(matrix, 5);
            Test(matrix, 20);
            Console.ReadKey(true);
        }

        static void Test(int[,] matrix, int target)
        {
            var solution = new Solution();
            var result = solution.SearchMatrix(matrix, target);
            Console.WriteLine(result);
        }
    }
}
