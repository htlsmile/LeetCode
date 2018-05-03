using System;
using System.Collections.Generic;
using System.Text;

namespace Shuffle_An_Array
{
    public class Solution
    {
        private int[] array;
        private int[] original;

        Random rand = new Random();

        private int RandRange(int min, int max)
        {
            return rand.Next(max - min) + min;
        }

        private void SwapAt(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public Solution(int[] nums)
        {
            array = nums;
            original = nums.Clone() as int[];
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return original.Clone() as int[];
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            for (int i = 0; i < array.Length; i++)
            {
                SwapAt(i, RandRange(i, array.Length));
            }
            return array;
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(nums);
     * int[] param_1 = obj.Reset();
     * int[] param_2 = obj.Shuffle();
     */
}
