using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction_To_Recurring_Decimal
{
    public class Solution
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                return "0";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(((numerator > 0) ^ (denominator > 0)) ? "-" : "");
            long num = Math.Abs((long)numerator);
            long den = Math.Abs((long)denominator);
            sb.Append(num / den);
            num %= den;
            if (num == 0)
            {
                return sb.ToString();
            }
            sb.Append(".");
            var dict = new Dictionary<long, int>
            {
                { num, sb.Length }
            };
            while (num != 0)
            {
                num *= 10;
                sb.Append(num / den);
                num %= den;
                if (dict.ContainsKey(num))
                {
                    sb.Insert(dict[num], "(");
                    sb.Append(")");
                    break;
                }
                else
                {
                    dict.Add(num, sb.Length);
                }
            }
            return sb.ToString();
        }
    }
}
