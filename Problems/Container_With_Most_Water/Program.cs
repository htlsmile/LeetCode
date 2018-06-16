using System;

namespace Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 3, 1, 4, 2 };
            Test(height);
            Console.ReadKey(true);
        }

        static void Test(int[] height)
        {
            var solution = new Solution();
            var result = solution.MaxArea(height);
            Console.WriteLine(result);
        }
    }
}
