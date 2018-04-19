using System;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 0, 4 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.ContainsDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}
