using System;
using System.Collections.Generic;
using System.Text;

namespace PowX_N
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n % 2 == 0)
            {
                return MyPow(x * x, n / 2);
            }
            else
            {
                return n > 0 ? MyPow(x * x, n / 2) * x : MyPow(x * x, n / 2) / x;
            }
        }
    }
}
