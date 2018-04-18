using System;

namespace Single_Number
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 2, 2, 3, 4, 4 };
            var result = solution.SingleNumber(nums);
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
