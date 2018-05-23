using System;
using System.Collections.Generic;
using System.Text;

namespace Unique_Paths
{
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            if (m > n)
            {
                return UniquePaths(n, m);
            }
            var list = new List<int>();
            for (int i = 0; i < m; i++)
            {
                list.Add(1);
            }
            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < m; i++)
                {
                    list[i] += list[i - 1];
                }
            }
            return list[m - 1];
        }
    }
}
