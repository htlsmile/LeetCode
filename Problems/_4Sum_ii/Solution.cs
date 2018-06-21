using System;
using System.Collections.Generic;
using System.Text;

namespace _4Sum_ii
{
    public class Solution
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            int result = 0;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    int temp = A[i] + B[j];
                    if (!dict.ContainsKey(temp))
                    {
                        dict.Add(temp, 1);
                    }
                    else
                    {
                        dict[temp]++;
                    }
                }
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    int temp = -(C[i] + D[j]);
                    if (dict.ContainsKey(temp))
                    {
                        result += dict[temp];
                    }
                }
            }
            return result;
        }
    }
}
