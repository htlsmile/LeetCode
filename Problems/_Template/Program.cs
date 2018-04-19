using System;

namespace _Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey(true);
        }

        static void Test(uint n)
        {
            var solution = new Solution();
            var result = solution.HammingWeight(n);
            Console.WriteLine(n);
        }
    }
}
