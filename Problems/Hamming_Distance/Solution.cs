using System;
using System.Collections.Generic;
using System.Text;

namespace Hamming_Distance
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            var z = x ^ y;
            int count = 0;
            while (z != 0)
            {
                z &= (z - 1);
                count++;
            }
            return count;
        }
    }
}
