using System;

namespace Search_In_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            Test(nums, 0);
            Test(nums, 3);
            Console.ReadKey(true);
        }

        static void Test(int[] nums, int target)
        {
            var solution = new Solution();
            var result = solution.Search(nums, target);
            Console.WriteLine(result);
        }
    }
}
