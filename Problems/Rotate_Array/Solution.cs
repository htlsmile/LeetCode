using System;
using System.Collections.Generic;
using System.Text;

namespace Rotate_Array
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        public static void Reverse(int[] nums, int start, int end)
        {
            if (start < 0 || end > nums.Length - 1 || start > end)
            {
                return;
            }
            int temp;
            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        //Time O(n^2), Space O(1)
        public void Rotate_1(int[] nums, int k)
        {
            k %= nums.Length;
            int moveNum = nums.Length - k;
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = nums[moveNum + i];
                for (int j = 0; j < moveNum; j++)
                {
                    int pos = moveNum + i - j;
                    nums[pos] = nums[pos - 1];
                }
                nums[i] = temp;
            }
        }
    }
}
