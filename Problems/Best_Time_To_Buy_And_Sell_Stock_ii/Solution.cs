using System;
using System.Collections.Generic;
using System.Text;

namespace Best_Time_To_Buy_And_Sell_Stock_ii
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    profit += (prices[i + 1] - prices[i]);
                }
            }
            return profit;
        }
    }
}
