using System;

namespace Find_The_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3, 4, 2, 2 };
            Test(nums1);
            int[] nums2 = { 3, 1, 3, 4, 2 };
            Test(nums2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.FindDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}
