using System;

namespace Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(2);
            Test(3);
            Test(44);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.ClimbStairs(n);
            Console.WriteLine(result);
        }
    }
}
