using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int num = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                num ^= nums[i];
            }
            return num;
        }
    }
}
