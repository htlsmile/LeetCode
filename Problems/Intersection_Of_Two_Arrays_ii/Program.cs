using System;

namespace Intersection_Of_Two_Arrays_ii
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            var result = solution.Intersect(nums1, nums2);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]}\t");
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
