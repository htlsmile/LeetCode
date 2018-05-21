using System;
using System.Collections.Generic;

namespace Merge_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervals1 = new List<Interval>()
            {new Interval(1,3),new Interval(2,6),new Interval(8,10),new Interval(15,18) };
            Test(intervals1);
            var intervals2 = new List<Interval>()
            { new Interval(1,4),new Interval(4,5)};
            Test(intervals2);
            Console.ReadKey(true);
        }

        static void Test(IList<Interval> intervals)
        {
            var solution = new Solution();
            var result = solution.Merge(intervals);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"[{result[i].start},{result[i].end}] ");
            }
            Console.WriteLine();
        }
    }
}
