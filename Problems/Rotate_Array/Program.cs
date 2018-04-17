using System;

namespace Rotate_Array
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            solution.Rotate(nums, k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}\t");
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
