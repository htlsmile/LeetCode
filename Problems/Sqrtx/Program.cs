using System;

namespace Sqrtx
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 17; i++)
            {
                Test(i);
            }
            Test(2147395599);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.MySqrt(n);
            Console.WriteLine($"Sqrt({n}):{result}");
        }
    }
}
