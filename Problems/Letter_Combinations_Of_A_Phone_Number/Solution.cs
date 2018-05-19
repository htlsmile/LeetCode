using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Letter_Combinations_Of_A_Phone_Number
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var list = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return list;
            }
            string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            list.Add("");
            for (int i = 0; i < digits.Length; i++)
            {
                if (int.TryParse(digits.Substring(i, 1), out int num))
                {
                    while (list[0].Length == i)
                    {
                        string t = list[0];
                        list.RemoveAt(0);
                        foreach (char s in map[num])
                        {
                            list.Add(t + s);
                        }
                    }
                }
            }
            return list;
        }
    }
}
