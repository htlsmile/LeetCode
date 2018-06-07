using System;
using System.Collections.Generic;
using System.Text;

namespace Happy_Number
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var list = new List<int>() { n };
            while (true)
            {
                int t = 0;
                while (n != 0)
                {
                    t += (n % 10) * (n % 10);
                    n /= 10;
                }
                if (t == 1)
                {
                    return true;
                }
                else if (list.Contains(t))
                {
                    return false;
                }
                else
                {
                    list.Add(t);
                    n = t;
                }
            }
        }
    }
}
