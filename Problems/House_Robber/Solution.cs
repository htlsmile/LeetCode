using System;
using System.Collections.Generic;
using System.Text;

namespace House_Robber
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a = Math.Max(a + nums[i], b);
                }
                else
                {
                    b = Math.Max(a, b + nums[i]);
                }
            }
            return Math.Max(a, b);
        }
    }
}
