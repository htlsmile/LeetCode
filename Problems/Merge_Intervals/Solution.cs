using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Merge_Intervals
{
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

    public class Solution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var result = new List<Interval>();
            var list = (from i in intervals
                        orderby i.start
                        select i).ToList();
            if (list.Count > 0)
            {
                result.Add(list[0]);
            }
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].start <= result.Last().end)
                {
                    result.Last().end = Math.Max(result.Last().end, list[i].end);
                }
                else
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }
    }
}
