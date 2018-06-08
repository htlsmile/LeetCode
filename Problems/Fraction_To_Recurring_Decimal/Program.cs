using System;

namespace Fraction_To_Recurring_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, 2);
            Test(2, 1);
            Test(2, 3);
            Test(25, -99);
            Test(-123456789, 999999999);
            Test(int.MinValue, 1);
            Test(int.MinValue, -1);
            Console.ReadKey(true);
        }

        static void Test(int numerator, int denominator)
        {
            var solution = new Solution();
            var result = solution.FractionToDecimal(numerator, denominator);
            Console.WriteLine(result);
        }
    }
}
