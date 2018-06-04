using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Scheduler
{
    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int interval = 0;
            int[] map = new int[26];
            for (int i = 0; i < tasks.Length; i++)
            {
                map[tasks[i] - 'A']++;
            }
            Array.Sort(map);
            while (map[25] > 0)
            {
                for (int i = 0; i <= n && map[25] > 0; i++)
                {
                    if (i < 26 && map[25 - i] > 0)
                    {
                        map[25 - i]--;
                    }
                    interval++;
                }
                Array.Sort(map);
            }
            return interval;
        }
    }
}
