using System;
using System.Collections.Generic;
using System.Text;

namespace Intersection_Of_Two_Arrays_ii
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            List<int> list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                list.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (list.Remove(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }
            return result.ToArray();
        }
    }
}
