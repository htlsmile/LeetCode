using System;
using System.Collections.Generic;
using System.Text;

namespace Subsets
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var list = new List<IList<int>>();
            Backtrack(list, nums, new List<int>(), 0);
            return list;
        }

        public void Backtrack(IList<IList<int>> r, int[] n, IList<int> l, int c)
        {
            r.Add(l);
            for (int i = c; i < n.Length; i++)
            {
                var list = new List<int>(l);
                if (!list.Contains(n[i]))
                {
                    list.Add(n[i]);
                    Backtrack(r, n, list, i);
                }
            }
        }
    }
}
