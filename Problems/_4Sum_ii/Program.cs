using System;

namespace _4Sum_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2 };
            int[] B = { -2, -1 };
            int[] C = { -1, 2 };
            int[] D = { 0, 2 };
            Test(A, B, C, D);
            Console.ReadKey(true);
        }

        static void Test(int[] A, int[] B, int[] C, int[] D)
        {
            var solution = new Solution();
            var result = solution.FourSumCount(A, B, C, D);
            Console.WriteLine(result);
        }
    }
}
