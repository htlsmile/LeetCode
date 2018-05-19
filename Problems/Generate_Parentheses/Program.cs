using System;

namespace Generate_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(3);
            Console.ReadKey(true);
        }

        static void Test(int n)
        {
            var solution = new Solution();
            var result = solution.GenerateParenthesis(n);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
