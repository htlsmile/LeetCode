using System;
using System.Collections.Generic;
using System.Text;

namespace Number_Of_1_Bits
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                n &= (n - 1);
                count++;
            }
            return count;
        }
    }
}
