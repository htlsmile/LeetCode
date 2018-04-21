using System;

namespace Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 0, 1 };
            Test(nums1);
            int[] nums2 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Test(nums2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.MissingNumber(nums);
            Console.WriteLine(result);
        }
    }
}
