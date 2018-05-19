using System;
using System.Collections.Generic;
using System.Text;

namespace Generate_Parentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            Backtrack(list, "", 0, 0, n);
            return list;
        }

        public void Backtrack(IList<string> list, string str, int l, int r, int n)
        {
            if (str.Length == n * 2)
            {
                list.Add(str);
                return;
            }
            if (l < n)
            {
                Backtrack(list, str + "(", l + 1, r, n);
            }
            if (r < l)
            {
                Backtrack(list, str + ")", l, r + 1, n);
            }
        }
    }
}
