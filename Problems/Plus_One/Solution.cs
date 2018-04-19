using System;
using System.Collections.Generic;
using System.Text;

namespace Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> nums = new List<int>();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                nums.Add(digits[i]);
            }
            bool carry = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (!carry)
                {
                    break;
                }
                nums[i]++;
                if (nums[i] > 9)
                {
                    nums[i] -= 10;
                    carry = true;
                }
                else
                {
                    carry = false;
                }
            }
            if (carry)
            {
                nums.Add(1);
            }
            nums.Reverse();
            return nums.ToArray();
        }
    }
}
