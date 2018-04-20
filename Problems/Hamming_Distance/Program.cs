using System;

namespace Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 4;
            Test(x, y);
            Console.ReadKey(true);
        }

        static void Test(int x, int y)
        {
            var solution = new Solution();
            var result = solution.HammingDistance(x, y);
            Console.WriteLine(result);
        }
    }
}
