﻿using System;

namespace Best_Time_To_Buy_And_Sell_Stock_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 7, 4, 3, 1, 5 };
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
