using System;

namespace Contains_Duplicate
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 0, 4 };
            var result = solution.ContainsDuplicate(nums);
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
