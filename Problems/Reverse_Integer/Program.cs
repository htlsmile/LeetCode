using System;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(123);
            Test(-123);
            Test(120);
            Console.ReadKey(true);
        }

        static void Test(int x)
        {
            var solution = new Solution();
            var result = solution.Reverse(x);
            Console.WriteLine(result);
        }
    }
}
