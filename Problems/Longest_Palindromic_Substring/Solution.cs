using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int start = 0, max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (max < len)
                {
                    start = i - (len - 1) / 2;
                    max = len;
                }
            }
            return s.Substring(start, max);
        }

        private int ExpandAroundCenter(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }
    }
}
