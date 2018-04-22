using System;
using System.Collections.Generic;
using System.Text;

namespace Implement_Strstr
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            //KMP算法
            return haystack.IndexOf(needle);
        }
    }
}
