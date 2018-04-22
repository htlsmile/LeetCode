using System;

namespace Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("A man, a plan, a canal: Panama");
            Test("race a car");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.IsPalindrome(s);
            Console.WriteLine(result);
        }
    }
}
