using System;

namespace Longest_Consecutive_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 9, 1, 4, 7, 3, -1, 5 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.LongestConsecutive(nums);
            Console.WriteLine(result);
        }
    }
}
