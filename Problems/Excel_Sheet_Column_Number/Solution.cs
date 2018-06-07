using System;
using System.Collections.Generic;
using System.Text;

namespace Excel_Sheet_Column_Number
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                num *= 26;
                num += (s[i] - 'A' + 1);
            }
            return num;
        }
    }
}
