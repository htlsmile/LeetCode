using System;
using System.Collections.Generic;
using System.Text;

namespace Valid_Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var t = s.ToLower();
            var list = new List<char>();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] >= 'a' && t[i] <= 'z')
                {
                    list.Add(t[i]);
                }
                else if (t[i] >= '0' && t[i] <= '9')
                {
                    list.Add(t[i]);
                }
            }
            int j = 0, k = list.Count - 1;
            while (j < k)
            {
                if (list[j] != list[k])
                {
                    return false;
                }
                j++;
                k--;
            }
            return true;
        }
    }
}
