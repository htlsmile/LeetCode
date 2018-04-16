using System;

namespace Best_Time_To_Buy_And_Sell_Stock_ii
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            int[] prices = { 1, 7, 4, 3, 1, 5 };
            var maxProfit = solution.MaxProfit(prices);
            Console.WriteLine(maxProfit);
            Console.ReadKey(true);
        }
    }
}
