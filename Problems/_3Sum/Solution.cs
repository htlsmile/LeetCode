using System;
using System.Collections.Generic;
using System.Text;

namespace _3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            int last = int.MaxValue;
            for (int i = 0; i < nums.Length - 2 && nums[i] <= 0; i++)
            {
                if (nums[i] == last)
                {
                    continue;
                }
                last = nums[i];
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum < 0)
                    {
                        j++;
                    }
                    else if (sum == 0)
                    {
                        var temp = new List<int>
                            {
                                nums[i],
                                nums[j],
                                nums[k]
                            };
                        result.Add(temp);
                        while (j < k && nums[j] == nums[j + 1])
                        {
                            j++;
                        }
                        while (j < k && nums[k] == nums[k - 1])
                        {
                            k--;
                        }
                        j++;
                        k--;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                }
            }
            return result;
        }
    }
}
