using System;

namespace hr.Medium.Mark_and_Toys
{
    public class Mark_and_Toys
    {
        // Complete the maximumToys function below.
        public static int maximumToys(int[] prices, int k)
        {
            int change = k;
            int count = 0;
            Array.Sort(prices);

            for (int i = 0; i < prices.Length; i++)
            {
                if (change - prices[i] > 0 && ((prices[i] <= (1000000000)) && (prices[i] >= 1)))
                {
                    change -= prices[i];
                    count++;
                }
            }
            return count;

        }
    }
}