using System;

namespace Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("abcabcbb");
            Test("bbbbb");
            Test("pwwkew");
            Test("c");
            Test("dvdf");
            Test("abcbad");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(result);
        }
    }
}
