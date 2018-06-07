using System;

namespace Excel_Sheet_Column_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("A");
            Test("AB");
            Test("ZY");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.TitleToNumber(s);
            Console.WriteLine(result);
        }
    }
}
