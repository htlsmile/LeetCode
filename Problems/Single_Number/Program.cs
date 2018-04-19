using System;

namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 2, 2, 3, 4, 4 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.SingleNumber(nums);
            Console.WriteLine(result);
        }
    }
}
