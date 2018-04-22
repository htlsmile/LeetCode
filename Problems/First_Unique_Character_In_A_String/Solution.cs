using System;
using System.Collections.Generic;
using System.Text;

namespace First_Unique_Character_In_A_String
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            List<char> repeats = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!repeats.Contains(s[i]))
                {
                    if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                    {
                        return s.IndexOf(s[i]);
                    }
                    else
                    {
                        repeats.Add(s[i]);
                    }
                }
            }
            return -1;
        }
    }
}
