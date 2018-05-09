using System;

namespace Group_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            Test(strs);
            Console.ReadKey(true);
        }

        static void Test(string[] strs)
        {
            var solution = new Solution();
            var result = solution.GroupAnagrams(strs);
            foreach (var strList in result)
            {
                foreach (var str in strList)
                {
                    Console.Write($"{str}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
