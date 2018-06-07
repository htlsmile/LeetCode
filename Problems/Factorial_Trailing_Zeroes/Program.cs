using System;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(3);
            Test(5);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.TrailingZeroes(n);
            Console.WriteLine(result);
        }
    }
}
