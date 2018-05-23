using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Increasing_Subsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            int max = 0;
            int[] dp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                max = Math.Max(max, dp[i]);
            }
            return max;
        }
    }
}
