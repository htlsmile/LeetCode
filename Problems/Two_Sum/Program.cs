using System;

namespace Two_Sum
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = solution.TwoSum(nums, target);
            Console.Write("[");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(i == 0 ? result[i].ToString() : ", " + result[i]);
            }
            Console.Write("]");
            Console.ReadKey(true);
        }
    }
}
