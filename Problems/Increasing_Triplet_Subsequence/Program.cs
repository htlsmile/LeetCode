using System;

namespace Increasing_Triplet_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            Test(nums1);
            int[] nums2 = { 5, 4, 3, 2, 1 };
            Test(nums2);
            int[] nums3 = { 3, 4, 1, 2, 5 };
            Test(nums3);
            int[] nums4 = { 2, 3, 1, 5, 4 };
            Test(nums4);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.IncreasingTriplet(nums);
            Console.WriteLine(result);
        }
    }
}
