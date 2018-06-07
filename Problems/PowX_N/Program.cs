using System;

namespace PowX_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(2, 10);
            Test(2.1, 3);
            Test(2, -2);
            Test(34.00515, -3);
            Test(2, int.MinValue);
            Console.ReadKey(true);
        }

        static void Test(double x, int n)
        {
            var solution = new Solution();
            var result = solution.MyPow(x, n);
            Console.WriteLine(result);
        }
    }
}
