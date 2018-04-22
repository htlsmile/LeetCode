using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Common_Prefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                var prefix = string.Empty;
                var str = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length < str.Length)
                    {
                        str = strs[i];
                    }
                }
                for (int i = 0; i < str.Length; i++)
                {
                    prefix = str.Substring(0, str.Length - i);
                    int j = 0;
                    while (j < strs.Length)
                    {
                        if (!strs[j].StartsWith(prefix))
                        {
                            break;
                        }
                        j++;
                    }
                    if (j == strs.Length)
                    {
                        return prefix;
                    }
                }
                return string.Empty;
            }
        }
    }
}
