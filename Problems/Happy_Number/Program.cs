using System;

namespace Happy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(19);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.IsHappy(n);
            Console.WriteLine(result);
        }
    }
}
