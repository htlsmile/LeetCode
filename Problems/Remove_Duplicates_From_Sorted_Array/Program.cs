using System;
using System.Text;

namespace Remove_Duplicates_From_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 2 };
            Test(nums1);
            int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Test(nums2);
            int[] nums3 = { 0, 1, 2, 1, 0, 2 };
            Test(nums3);
            Console.ReadKey(true);
        }

        static void Test(int[] nums)
        {
            var solution = new Solution();
            StringBuilder sb = new StringBuilder();
            var length = solution.RemoveDuplicates(nums);
            if (length > 0)
            {
                sb.Append(nums[0]);
                for (int i = 1; i < length; i++)
                {
                    sb.Append($", {nums[i]}");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
