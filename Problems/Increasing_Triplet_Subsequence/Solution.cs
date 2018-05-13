using System;
using System.Collections.Generic;
using System.Text;

namespace Increasing_Triplet_Subsequence
{
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int n1 = int.MaxValue, n2 = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= n1)
                {
                    n1 = nums[i];
                }
                else if (nums[i] <= n2)
                {
                    n2 = nums[i];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
