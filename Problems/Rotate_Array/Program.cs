﻿using System;

namespace Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Test(nums, k);
            Console.ReadKey(true);
        }

        static void Test(int[] nums, int k)
        {
            var solution = new Solution();
            solution.Rotate(nums, k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
