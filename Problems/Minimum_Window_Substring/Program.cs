using System;

namespace Minimum_Window_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("ADOBECODEBANC", "ABC");
            Console.ReadKey(true);
        }

        static void Test(string s, string t)
        {
            var solution = new Solution();
            var result = solution.MinWindow(s, t);
            Console.WriteLine(result);
        }
    }
}
