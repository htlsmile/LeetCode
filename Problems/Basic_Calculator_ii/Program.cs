using System;

namespace Basic_Calculator_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("3+2*2");//7
            Test(" 3/2 ");//1
            Test(" 3+5 / 2 ");//5
            Test(" 1 + 2 - 3 * 4 / 5 * 6 + 7 ");//-2
            Test(" 12 - 34 * 56 + 78 / 9 ");//-1884
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.Calculate(s);
            Console.WriteLine(result);
        }
    }
}
