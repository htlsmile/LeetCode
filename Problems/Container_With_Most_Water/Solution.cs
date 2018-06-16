using System;
using System.Collections.Generic;
using System.Text;

namespace Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int max = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                max = Math.Max(max, (r - l) * Math.Min(height[l], height[r]));
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return max;
        }
    }
}
