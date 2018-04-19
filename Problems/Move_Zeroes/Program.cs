using System;

namespace Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            Test(nums1);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            solution.MoveZeroes(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
