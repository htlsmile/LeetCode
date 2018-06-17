using System;
using System.Collections.Generic;
using System.Text;

namespace First_Missing_Positive
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    int t = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = t;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }
            if (nums.Length > 0 && nums[nums.Length - 1] == nums.Length)
            {
                return nums.Length + 1;
            }
            return 1;
        }
    }
}
