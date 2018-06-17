using System;

namespace First_Missing_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 0 };
            Test(nums1);
            int[] nums2 = { 3, 4, -1, 1 };
            Test(nums2);
            int[] nums3 = { 7, 8, 9, 11, 12 };
            Test(nums3);
            int[] nums4 = { 10, 9, 8, 7, 6, 4, 3, 2, 1, 0, -1, -2, -3 };
            Test(nums4);
            int[] nums5 = { 1, 2, 3, 4, 5 };
            Test(nums5);
            int[] nums6 = { 1,-1,-2,-3 };
            Test(nums6);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.FirstMissingPositive(nums);
            Console.WriteLine(result);
        }
    }
}
