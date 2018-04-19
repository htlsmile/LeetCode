using System;
using System.Collections.Generic;
using System.Text;

namespace Move_Zeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int count = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                nums[nums.Length - 1 - i] = 0;
            }
        }
    }
}
