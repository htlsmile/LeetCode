using System;

namespace Roman_To_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("III");//3
            Test("IV");//4
            Test("IX");//9
            Test("LVIII");//58
            Test("MCMXCIV");//1994
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.RomanToInt(s);
            Console.WriteLine(result);
        }
    }
}
