using System;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("anagram", "nagaram");
            Test("rat", "car");
            Console.ReadKey(true);
        }

        static void Test(string s, string t)
        {
            var solution = new Solution();
            var result = solution.IsAnagram(s, t);
            Console.WriteLine(result);
        }
    }
}
