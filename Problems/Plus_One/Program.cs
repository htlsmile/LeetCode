using System;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            Test(array1);
            int[] array2 = { 4, 3, 2, 1 };
            Test(array2);
            int[] array3 = { 9 };
            Test(array3);
            int[] array4 = { 8, 9, 9, 9 };
            Test(array4);
            Console.ReadKey(true);
        }

        static void Test(int[] digits)
        {
            var solution = new Solution();
            var result = solution.PlusOne(digits);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
