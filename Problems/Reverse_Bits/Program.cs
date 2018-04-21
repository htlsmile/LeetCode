using System;

namespace Reverse_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 43261596;
            Test(n);
            Console.ReadKey(true);
        }

        static void Test(uint n)
        {
            var solution = new Solution();
            var result = solution.reverseBits(n);
            Console.WriteLine(result);
        }
    }
}
