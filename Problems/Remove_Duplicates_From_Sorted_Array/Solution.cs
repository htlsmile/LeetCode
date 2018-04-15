using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Duplicates_From_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }

        /// <summary>
        /// 未排序数组删除重复元素
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicatesNonSorted(int[] nums)
        {
            int length = nums.Length;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            for (int k = j; k < length - 1; k++)
                            {
                                nums[k] = nums[k + 1];
                            }
                            length -= 1;
                            j--;
                        }
                    }
                }
            }
            return length;
        }
    }
}
