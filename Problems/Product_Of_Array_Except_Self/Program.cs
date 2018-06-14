using System;

namespace Product_Of_Array_Except_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            Test(nums);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.ProductExceptSelf(nums);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
