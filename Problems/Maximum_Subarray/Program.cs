using System;

namespace Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.MaxSubArray(nums);
            Console.WriteLine(result);
        }
    }
}
