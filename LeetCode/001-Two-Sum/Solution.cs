using System.Collections.Generic;

namespace _001_Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int key;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                key = target - nums[i];
                if (dict.ContainsKey(key))
                {
                    return new int[] { dict[key], i };
                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            //throw new ArgumentException();
            return new int[] { -1, -1 };
        }
    }
}
