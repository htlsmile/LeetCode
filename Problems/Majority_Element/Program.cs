using System;

namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 3 };
            Test(nums1);
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            Test(nums2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.MajorityElement(nums);
            Console.WriteLine(result);
        }
    }
}
