using System;
using System.Collections.Generic;
using System.Text;

namespace Sqrtx
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            int low = 1, high = x;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (x / mid >= mid)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return low - 1;
        }
    }
}
