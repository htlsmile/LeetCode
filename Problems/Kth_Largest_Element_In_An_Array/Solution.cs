using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kth_Largest_Element_In_An_Array
{
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            return (from n in nums
                    orderby n descending
                    select n).Skip(k - 1).FirstOrDefault();
        }
    }
}
