using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluate_Reverse_Polish_Notation
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            var list = new List<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+")
                {
                    var t = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list[list.Count - 1] += t;
                }
                else if (tokens[i] == "-")
                {
                    var t = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list[list.Count - 1] -= t;
                }
                else if (tokens[i] == "*")
                {
                    var t = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list[list.Count - 1] *= t;
                }
                else if (tokens[i] == "/")
                {
                    var t = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list[list.Count - 1] /= t;
                }
                else
                {
                    if (int.TryParse(tokens[i], out int t))
                    {
                        list.Add(t);
                    }
                }
            }
            return list[0];
        }
    }
}
