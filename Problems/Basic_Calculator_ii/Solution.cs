using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Calculator_ii
{
    public class Solution
    {
        public int Calculate(string s)
        {
            s = s.Replace(" ", "");
            Stack<int> nums = new Stack<int>();
            int n = 0;
            char sign = '+';
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    n = n * 10 + s[i] - '0';
                }
                if (!char.IsDigit(s[i]) || i == s.Length - 1)
                {
                    if (sign == '+')
                    {
                        nums.Push(n);
                    }
                    else if (sign == '-')
                    {
                        nums.Push(-n);
                    }
                    else if (sign == '*')
                    {
                        nums.Push(nums.Pop() * n);
                    }
                    else if (sign == '/')
                    {
                        nums.Push(nums.Pop() / n);
                    }
                    sign = s[i];
                    n = 0;
                }
            }
            int result = 0;
            while (nums.Count > 0)
            {
                result += nums.Pop();
            }
            return result;
        }
    }
}
