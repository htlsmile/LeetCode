using System;
using System.Collections.Generic;
using System.Text;

namespace Divide_Two_Integers
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            else if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }
            bool sign = (dividend < 0) ^ (divisor < 0);
            long dvd = dividend;
            if (dvd < 0)
            {
                dvd = -dvd;
            }
            long dvs = divisor;
            if (dvs < 0)
            {
                dvs = -dvs;
            }
            long res = 0;
            while (dvd >= dvs)
            {
                long temp = dvs, multiple = 1;
                while (dvd >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                dvd -= temp;
                res += multiple;
            }
            if (sign)
            {
                res = -res;
            }
            return (int)res;
        }
    }
}
