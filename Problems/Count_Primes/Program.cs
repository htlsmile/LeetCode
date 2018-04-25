using System;

namespace Count_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(10000);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.CountPrimes(n);
            Console.WriteLine(result);
        }
    }
}
