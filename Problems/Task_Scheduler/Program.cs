using System;

namespace Task_Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tasks = { 'A', 'A', 'A', 'B', 'B', 'B' };
            int n = 2;
            Test(tasks, n);
            Console.ReadKey(true);
        }

        static void Test(char[] tasks, int n)
        {
            var solution = new Solution();
            var result = solution.LeastInterval(tasks, n);
            Console.WriteLine(result);
        }
    }
}
