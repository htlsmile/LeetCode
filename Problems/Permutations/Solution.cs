using System;
using System.Collections.Generic;
using System.Text;

namespace Permutations
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            Backtrack(list, nums, new List<int>(), 0);
            return list;
        }

        public void Backtrack(IList<IList<int>> r, int[] n, IList<int> l, int c)
        {
            if (c == n.Length)
            {
                r.Add(l);
                return;
            }
            foreach (var item in n)
            {
                var list = new List<int>(l);
                if (!list.Contains(item))
                {
                    list.Add(item);
                    Backtrack(r, n, list, c + 1);
                }
            }
        }
    }
}
