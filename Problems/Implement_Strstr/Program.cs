using System;

namespace Implement_Strstr
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("hello", "ll");
            Test("aaaaa", "bba");
            Test("aaaaa", "");
            Console.ReadKey(true);
        }

        static void Test(string haystack, string needle)
        {
            var solution = new Solution();
            var result = solution.StrStr(haystack, needle);
            Console.WriteLine(result);
        }
    }
}
