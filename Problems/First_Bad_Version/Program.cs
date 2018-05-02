using System;

namespace First_Bad_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(100);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.FirstBadVersion(n);
            Console.WriteLine(result);
        }
    }
}
