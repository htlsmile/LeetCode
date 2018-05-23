using System;
using System.Collections.Generic;
using System.Text;

namespace Jump_Game
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int last = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= last)
                {
                    last = i;
                }
            }
            return last == 0;
        }
    }
}
