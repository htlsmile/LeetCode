using System;
using System.Collections.Generic;
using System.Text;

namespace Coin_Change
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            return CoinChange(coins, amount, new int[amount]);
        }

        public int CoinChange(int[] coins, int amount, int[] counts)
        {
            if (amount == 0)
            {
                return 0;
            }
            else if (amount < 0)
            {
                return -1;
            }
            else if (counts[amount - 1] == 0)
            {
                int min = int.MaxValue;
                for (int i = 0; i < coins.Length; i++)
                {
                    int count = 1 + CoinChange(coins, amount - coins[i], counts);
                    if (count > 0 && count < min)
                    {
                        min = count;
                    }
                }
                counts[amount - 1] = min == int.MaxValue ? -1 : min;
            }
            return counts[amount - 1];
        }
    }
}
