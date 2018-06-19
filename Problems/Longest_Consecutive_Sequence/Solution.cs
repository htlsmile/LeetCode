using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Consecutive_Sequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var result = 0;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (!dict.ContainsKey(n))
                {
                    int left = dict.ContainsKey(n - 1) ? dict[n - 1] : 0;
                    int right = dict.ContainsKey(n + 1) ? dict[n + 1] : 0;
                    int sum = left + right + 1;
                    dict.Add(n, sum);
                    result = Math.Max(result, sum);
                    dict[n - left] = sum;
                    dict[n + right] = sum;
                }
            }
            return result;
        }
    }
}
