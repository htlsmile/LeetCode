using System;
using System.Collections.Generic;
using System.Text;

namespace Valid_Anagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var list1 = new List<char>();
            var list2 = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                list1.Add(s[i]);
                list2.Add(t[i]);
            }
            list1.Sort();
            list2.Sort();
            for (int i = 0; i < s.Length; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
