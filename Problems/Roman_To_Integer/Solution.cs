using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_To_Integer
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            s = s.ToUpper();
            char last = ' ';
            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        result += (last == 'V' || last == 'X') ? -1 : 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        result += (last == 'L' || last == 'C') ? -10 : 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        result += (last == 'D' || last == 'M') ? -100 : 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                    default:
                        break;
                }
                last = s[i];
            }
            return result;
        }
    }
}
