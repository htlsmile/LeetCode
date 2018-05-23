using System;

namespace Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 3, 1, 1, 4 };
            Test(nums1);
            int[] nums2 = { 3, 2, 1, 0, 4 };
            Test(nums2);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            var result = solution.CanJump(nums);
            Console.WriteLine(result);
        }
    }
}
