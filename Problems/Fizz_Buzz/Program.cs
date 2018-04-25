using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(15);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var list = solution.FizzBuzz(n);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
