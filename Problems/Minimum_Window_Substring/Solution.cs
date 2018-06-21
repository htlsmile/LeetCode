using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minimum_Window_Substring
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            var list = Enumerable.Repeat(0, 128).ToList();
            foreach (var c in t.ToCharArray())
            {
                list[c]++;
            }
            int count = t.Length, begin = 0, end = 0, d = int.MaxValue, head = 0;
            while (end < s.Length)
            {
                if (list[s[end]] > 0)
                {
                    count--;
                }
                list[s[end]]--;
                end++;
                while (count == 0)
                {
                    if (end - begin < d)
                    {
                        head = begin;
                        d = end - head;
                    }
                    if (list[s[begin]] == 0)
                    {
                        count++;
                    }
                    list[s[begin]]++;
                    begin++;
                }
            }
            return d == int.MaxValue ? "" : s.Substring(head, d);
        }
    }
}
