using System;

namespace Find_Peak_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 };
            Test(nums1);
            int[] nums2 = { 1, 2, 1, 3, 5, 6, 4 };
            Test(nums2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.FindPeakElement(nums);
            Console.WriteLine(result);
        }
    }
}
