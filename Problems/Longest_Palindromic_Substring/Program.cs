using System;

namespace Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("babad");//bab或aba
            Test("cbbd");//bb
            Test("eabcb");//bcb
            Test("a");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.LongestPalindrome(s);
            Console.WriteLine(result);
        }
    }
}
