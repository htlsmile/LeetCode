using System;

namespace Unique_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(3, 2);
            Test(2, 3);
            Test(7, 3);
            Test(23, 12);
            Console.ReadKey(true);
        }

        static void Test(int m, int n)
        {
            var solution = new Solution();
            var result = solution.UniquePaths(m, n);
            Console.WriteLine(result);
        }
    }
}
