using System;

namespace Shuffle_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution(nums);
            var result1 = solution.Shuffle();
            for (int i = 0; i < result1.Length; i++)
            {
                Console.Write($"{result1[i]}\t");
            }
            Console.WriteLine();
            var result2 = solution.Reset();
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write($"{result2[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
