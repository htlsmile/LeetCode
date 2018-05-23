using System;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.LengthOfLIS(nums);
            Console.WriteLine(result);
        }
    }
}
