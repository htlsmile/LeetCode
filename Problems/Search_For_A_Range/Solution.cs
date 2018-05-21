using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Search_For_A_Range
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            return new int[]{
                nums.ToList().IndexOf(target),
                nums.ToList().LastIndexOf(target)
            };
        }
    }
}
