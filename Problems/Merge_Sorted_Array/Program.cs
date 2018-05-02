using System;

namespace Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            Test(nums1, m, nums2, n);
            Console.ReadKey(true);
        }

        static void Test(int[] nums1, int m, int[] nums2, int n)
        {
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.Write($"{nums1[i]}\t");
            }
        }
    }
}
