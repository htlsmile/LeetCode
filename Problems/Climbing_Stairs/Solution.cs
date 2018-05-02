using System;
using System.Collections.Generic;
using System.Text;

namespace Climbing_Stairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            List<int> fib = new List<int>(n + 1);
            fib.Add(1);
            fib.Add(1);
            for (int i = 2; i <= n; i++)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
            }
            return fib[n];
        }

        //Time Limit Exceeded
        public int ClimbStairs_Brute_Force(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            }
        }
    }
}
