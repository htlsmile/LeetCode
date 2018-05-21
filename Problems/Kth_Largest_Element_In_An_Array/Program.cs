using System;

namespace Kth_Largest_Element_In_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 1, 5, 6, 4 };
            int k1 = 2;
            Test(nums1, k1);
            int[] nums2 = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int k2 = 4;
            Test(nums2, k2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums, int k)
        {
            var solution = new Solution();
            var result = solution.FindKthLargest(nums, k);
            Console.WriteLine(result);
        }
    }
}
