using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("hello");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.ReverseString(s);
            Console.WriteLine(result);
        }
    }
}
