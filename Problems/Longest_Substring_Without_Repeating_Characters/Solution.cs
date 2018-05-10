using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> list = new List<char>();
            int maxLength = 0, i = 0, j = 0;
            while (i < s.Length && j < s.Length)
            {
                if (!list.Contains(s[j]))
                {
                    list.Add(s[j]);
                    j++;
                    maxLength = Math.Max(maxLength, j - i);
                }
                else
                {
                    list.Remove(s[i]);
                    i++;
                }
            }
            return maxLength;
        }
    }
}
