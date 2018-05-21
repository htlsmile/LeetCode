using System;

namespace Search_For_A_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 5, 7, 7, 8, 8, 10 };
            int target1 = 8;
            Test(nums1, target1);
            int[] nums2 = { 5, 7, 7, 8, 8, 10 };
            int target2 = 6;
            Test(nums2, target2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums, int target)
        {
            var solution = new Solution();
            var result = solution.SearchRange(nums, target);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.WriteLine();
        }
    }
}
