using System;

namespace Top_K_Frequent_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            Test(nums, k);
            Console.ReadKey(true);
        }

        static void Test(int[] nums, int k)
        {
            var solution = new Solution();
            var result = solution.TopKFrequent(nums, k);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
