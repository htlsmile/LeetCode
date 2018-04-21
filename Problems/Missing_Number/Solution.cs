using System;
using System.Collections.Generic;
using System.Text;

namespace Missing_Number
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int result = (nums.Length + 1) * nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                result -= nums[i];
            }
            return result;
        }
    }
}
