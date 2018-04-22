using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_String
{
    public class Solution
    {
        public string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[s.Length - 1 - i]);
            }
            return sb.ToString();
        }
    }
}
