using System;
using System.Collections.Generic;
using System.Text;

namespace Pascals_Triangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                list.Add(new List<int>());
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        list[i].Add(1);
                    }
                    else
                    {
                        list[i].Add(list[i - 1][j - 1] + list[i - 1][j]);
                    }
                }
            }
            return list;
        }
    }
}
