using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Search_In_Rotated_Sorted_Array
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1, mid;
            while (low < high)
            {
                mid = (low + high) / 2;
                if (nums[high] < nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            int min = low;
            low = 0;
            high = nums.Length - 1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                int mid2 = (mid + min) % nums.Length;
                if (nums[mid2] == target)
                {
                    return mid2;
                }
                else if (nums[mid2] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}