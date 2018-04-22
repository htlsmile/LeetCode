using System;
using System.Collections.Generic;
using System.Text;

namespace String_To_Integer_atoi
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            bool isPositive = true;
            var s = str.TrimStart();
            long num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    if (s[i] == '+')
                    {
                        isPositive = true;
                        continue;
                    }
                    else if (s[i] == '-')
                    {
                        isPositive = false;
                        continue;
                    }
                }
                if (s[i] >= '0' && s[i] <= '9')
                {
                    num *= 10;
                    num += (s[i] - '0');
                    if (isPositive && num > int.MaxValue)
                    {
                        return int.MaxValue;
                    }
                    else if (!isPositive && num * -1 < int.MinValue)
                    {
                        return int.MinValue;
                    }
                }
                else
                {
                    break;
                }
            }
            if (!isPositive)
            {
                num *= -1;
            }
            return (int)num;
        }
    }
}
