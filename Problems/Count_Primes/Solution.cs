using System;
using System.Collections.Generic;
using System.Text;

namespace Count_Primes
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            var count = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime((ulong)i))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 质数判断
        /// </summary>
        /// <param name="num">质数</param>
        /// <returns></returns>
        public static bool IsPrime(ulong num)
        {
            if (num < 2)
            {
                return false;
            }
            else if (num < 4)
            {
                return true;
            }
            else if (num % 6 != 1 && num % 6 != 5)
            {
                return false;
            }
            else
            {
                ulong temp = Convert.ToUInt64(Math.Sqrt(num));
                ulong divisor = 5;
                ulong increment = 2;
                while (divisor <= temp)
                {
                    if (num % divisor == 0)
                    {
                        return false;
                    }
                    divisor += increment;
                    increment ^= 6;
                }
                return true;
            }
        }
    }
}
