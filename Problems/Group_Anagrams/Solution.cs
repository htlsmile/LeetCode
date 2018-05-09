using System;
using System.Collections.Generic;
using System.Text;

namespace Group_Anagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var charArray = strs[i].ToCharArray();
                Array.Sort(charArray);
                var key = new string(charArray);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>() { strs[i] });
                }
                else
                {
                    dict[key].Add(strs[i]);
                }
            }
            var result = new List<IList<string>>(dict.Values);
            return result;
        }
    }
}
