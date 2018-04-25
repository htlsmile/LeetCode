using System;
using System.Collections.Generic;
using System.Text;

namespace Fizz_Buzz
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();
            bool flag = false;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                flag = false;
                sb.Clear();
                if (i % 3 == 0)
                {
                    sb.Append("Fizz");
                    flag = true;
                }
                if (i % 5 == 0)
                {
                    sb.Append("Buzz");
                    flag = true;
                }
                if (!flag)
                {
                    sb.Append(i.ToString());
                }
                list.Add(sb.ToString());
            }
            return list;
        }
    }
}
