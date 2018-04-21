using System;
using System.Collections.Generic;
using System.Text;

namespace Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            char ch;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (!stack.TryPop(out ch))
                {
                    return false;
                }
                else
                {
                    if (s[i] == ')' && ch != '(')
                    {
                        return false;
                    }
                    else if (s[i] == ']' && ch != '[')
                    {
                        return false;
                    }
                    else if (s[i] == '}' && ch != '{')
                    {
                        return false;
                    }
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
