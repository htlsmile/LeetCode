using System;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(new string[] { "flower", "flow", "flight" });
            Test(new string[] { "dog", "racecar", "car" });
            Console.ReadKey(true);
        }

        static void Test(string[] strs)
        {
            var solution = new Solution();
            var result = solution.LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }
    }
}
