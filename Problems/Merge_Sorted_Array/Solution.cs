using System;
using System.Collections.Generic;
using System.Text;

namespace Merge_Sorted_Array
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, k = m + n - 1;
            while (i > -1 && j > -1)
            {
                nums1[k--] = (nums1[i] > nums2[j]) ? nums1[i--] : nums2[j--];
            }
            while (j > -1)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
