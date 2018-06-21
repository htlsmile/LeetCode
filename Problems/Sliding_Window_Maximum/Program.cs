using System;

namespace Sliding_Window_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            Test(nums, k);
            Console.ReadKey(true);
        }

        static void Test(int[] nums, int k)
        {
            var solution = new Solution();
            var result = solution.MaxSlidingWindow(nums, k);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
