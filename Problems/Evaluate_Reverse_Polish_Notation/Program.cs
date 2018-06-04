using System;

namespace Evaluate_Reverse_Polish_Notation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = { "2", "1", "+", "3", "*" };
            Test(str1);
            string[] str2 = { "4", "13", "5", "/", "+" };
            Test(str2);
            string[] str3 = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            Test(str3);
            Console.ReadKey(true);
        }

        static void Test(string[] tokens)
        {
            var solution = new Solution();
            var result = solution.EvalRPN(tokens);
            Console.WriteLine(result);
        }
    }
}
