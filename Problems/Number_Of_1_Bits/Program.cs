using System;

namespace Number_Of_1_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(11);
            Console.ReadKey(true);
        }

        static void Test(uint n)
        {
            var solution = new Solution();
            var result = solution.HammingWeight(n);
            Console.WriteLine(result);
        }
    }
}
