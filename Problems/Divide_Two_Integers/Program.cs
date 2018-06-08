using System;

namespace Divide_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(10, 3);
            Test(7, -3);
            Test(int.MinValue, 1);
            Test(int.MinValue, -1);
            Console.ReadKey(true);
        }

        static void Test(int dividend, int divisor)
        {
            var solution = new Solution();
            var result = solution.Divide(dividend, divisor);
            Console.WriteLine(result);
        }
    }
}
