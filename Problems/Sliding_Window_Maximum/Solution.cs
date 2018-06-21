using System;
using System.Collections.Generic;
using System.Text;

namespace Sliding_Window_Maximum
{
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var result = new List<int>();
            if (nums.Length < 1)
            {
                return result.ToArray();
            }
            var list = new List<int>(k);
            var max = int.MinValue;
            for (int i = 0; i < k; i++)
            {
                list.Add(nums[i]);
                max = Math.Max(max, nums[i]);
            }
            result.Add(max);
            for (int i = k; i < nums.Length; i++)
            {
                var flag = list[0] == max;
                list.RemoveAt(0);
                list.Add(nums[i]);
                if (flag)
                {
                    max = int.MinValue;
                    for (int j = 0; j < list.Count; j++)
                    {
                        max = Math.Max(max, list[j]);
                    }
                }
                else
                {
                    max = Math.Max(max, nums[i]);
                }
                result.Add(max);
            }
            return result.ToArray();
        }
    }
}
