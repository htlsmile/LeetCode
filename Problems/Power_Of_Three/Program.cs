using System;

namespace Power_Of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(27);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.IsPowerOfThree(n);
            Console.WriteLine(result);
        }
    }
}
