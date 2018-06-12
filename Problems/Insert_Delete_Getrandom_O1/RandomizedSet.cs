using System;
using System.Collections.Generic;
using System.Text;

namespace Insert_Delete_GetRandom_O1
{
    public class RandomizedSet
    {
        private readonly Random rand;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dict;

        public RandomizedSet()
        {
            rand = new Random();
            list = new List<int>();
            dict = new Dictionary<int, int>();
        }

        public bool Insert(int val)
        {
            if (dict.ContainsKey(val))
            {
                return false;
            }
            dict.Add(val, list.Count);
            list.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val))
            {
                return false;
            }
            int index = dict[val];
            if (index < list.Count - 1)
            {
                int last = list[list.Count - 1];
                list[index] = last;
                dict[last] = index;
            }
            dict.Remove(val);
            list.RemoveAt(list.Count - 1);
            return true;
        }

        public int GetRandom()
        {
            return list.Count == 0 ? 0 : list[rand.Next(list.Count)];
        }
    }
}
