using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial_Trailing_Zeroes
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count += n / 5;
                n /= 5;
            }
            return count;
        }
    }
}
