using System;
using System.Collections.Generic;
using System.Text;

namespace Majority_Element
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }
    }
}
