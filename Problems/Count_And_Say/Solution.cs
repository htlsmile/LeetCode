using System;
using System.Collections.Generic;
using System.Text;

namespace Count_And_Say
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            var list = new List<string>() { "1" };
            for (int i = 1; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < list[i - 1].Length; j++)
                {
                    var ch = list[i - 1][j];
                    int count = 1;
                    for (int k = j + 1; k < list[i - 1].Length; k++)
                    {
                        if (list[i - 1][k] == ch)
                        {
                            count++;
                            j++;
                        }
                        else
                        {
                            j = k - 1;
                            break;
                        }
                    }
                    sb.Append(count);
                    sb.Append(ch);
                }
                list.Add(sb.ToString());
            }
            return list[n - 1];
        }
    }
}
