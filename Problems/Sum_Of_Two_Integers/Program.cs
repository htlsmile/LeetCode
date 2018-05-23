using System;

namespace Sum_Of_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, 2);
            Console.ReadKey(true);
        }

        static void Test(int a, int b)
        {
            var solution = new Solution();
            var result = solution.GetSum(a, b);
            Console.WriteLine(result);
        }
    }
}
