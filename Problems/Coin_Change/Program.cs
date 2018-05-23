using System;

namespace Coin_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins1 = { 1, 2, 5 };
            int amount1 = 11;
            Test(coins1, amount1);
            int[] coins2 = { 2 };
            int amount2 = 3;
            Test(coins2, amount2);
            Console.ReadKey(true);
        }

        static void Test(int[] coins, int amount)
        {
            var solution = new Solution();
            var result = solution.CoinChange(coins, amount);
            Console.WriteLine(result);
        }
    }
}
