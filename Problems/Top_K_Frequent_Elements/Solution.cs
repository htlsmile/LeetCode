using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Top_K_Frequent_Elements
{
    public class Solution
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            var keys = (from d in dict
                        orderby d.Value descending
                        select d.Key).Take(k).ToList();
            return keys;
        }
    }
}
