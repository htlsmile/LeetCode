using System;

namespace First_Unique_Character_In_A_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("leetcode");
            Test("loveleetcode");
            Console.ReadKey(true);
        }

        static void Test(string s)
        {
            var solution = new Solution();
            var result = solution.FirstUniqChar(s);
            Console.WriteLine(result);
        }
    }
}
