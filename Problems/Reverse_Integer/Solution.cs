using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long y = 0;
            while (x != 0)
            {
                y *= 10;
                y += x % 10;
                x /= 10;
            }
            if (y > int.MaxValue || y < int.MinValue)
            {
                return 0;
            }
            return (int)y;
        }
    }
}
