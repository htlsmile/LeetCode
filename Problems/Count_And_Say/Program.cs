using System;

namespace Count_And_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1);
            Test(2);
            Test(3);
            Test(4);
            Test(5);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.CountAndSay(n);
            Console.WriteLine(result);
        }
    }
}
