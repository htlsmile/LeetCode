using System;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("()");
            Test("()[]{}");
            Test("(]");
            Test("([)]");
            Test("{[]}");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.IsValid(s);
            Console.WriteLine(result);
        }
    }
}
