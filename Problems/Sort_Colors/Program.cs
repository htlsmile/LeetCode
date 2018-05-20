using System;

namespace Sort_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            solution.SortColors(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
    }
}
