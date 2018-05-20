using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_Colors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int[] index = { -1, -1, -1 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums[i]; j > -1; j--)
                {
                    if (index[j] != -1)
                    {
                        index[nums[i]] = index[j] + 1;
                        break;
                    }
                }
                if (index[nums[i]] == -1)
                {
                    index[nums[i]]++;
                }
                for (int j = nums[i] + 1; j < index.Length; j++)
                {
                    if (index[j] != -1)
                    {
                        index[j]++;
                    }
                }
                int cur = index[nums[i]];
                if (i > cur)
                {
                    int t = nums[i];
                    for (int j = i; j > cur; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[cur] = t;
                }
            }
        }
    }
}
