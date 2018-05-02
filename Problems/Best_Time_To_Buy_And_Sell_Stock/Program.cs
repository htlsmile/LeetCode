using System;

namespace Best_Time_To_Buy_And_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Test(prices);
            Console.ReadKey(true);
        }

        static void Test(int[] prices)
        {
            var solution = new Solution();
            var result = solution.MaxProfit(prices);
            Console.WriteLine(result);
        }
    }
}
