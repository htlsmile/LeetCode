using System;
using System.Collections.Generic;

namespace Letter_Combinations_Of_A_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("23");
            Console.ReadKey(true);
        }

        static void Test(string digits)
        {
            var solution = new Solution();
            var result = solution.LetterCombinations(digits);
            Show(result); 
        }

        static void Show(IList<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
