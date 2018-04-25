using System;
using System.Collections.Generic;
using System.Text;

namespace Power_Of_Three
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            return (n > 0 && 1162261467 % n == 0);
        }
    }
}
