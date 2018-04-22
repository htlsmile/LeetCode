using System;

namespace String_To_Integer_atoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42");
            Test("   -42");
            Test("4193 with words");
            Test("words and 987");
            Test("-91283472332");
            Test("");
            Console.ReadKey(true);
        }

        static void Test(string str)
        {
            var solution = new Solution();
            var result = solution.MyAtoi(str);
            Console.WriteLine(result);
        }
    }
}
