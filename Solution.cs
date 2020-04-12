using System;
using System.Linq;

namespace practice
{
    public class Solution
    {
        /* Mini-Max Sum */
        public void miniMaxSum(int[] arr)
        {
            long total = 0;
            long min = arr[0];
            long max = 10 ^ 9;
            foreach (int item in arr)
            {
                total += item;
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine((total - max) + " " + (total - min));
        }
        /* Birthday Cake Candles */
        public int birthdayCakeCandles(int[] ar)
        {
            int tallest = ar[0];
            int count = 0;
            foreach (int item in ar)
            {
                if (item == tallest)
                {
                    count += 1;
                }

                if (item > tallest)
                {

                    tallest = item;
                    count = 1;
                }
            }
            return count;
        }
        /* Time Conversion */
        public string timeConversion(string s)
        {
            DateTime parsedDate = DateTime.Parse(s);
            return parsedDate.ToString("HH:mm:ss");
        }
        /* Mark and Toys */
        public int maximumToys(int[] prices, int k)
        {
            int change = k;
            int count = 0;

            /* Insertion sort not good enough
            int n, j;
            for (int i = 0; i < prices.Length; i++)
            {
                n = prices[i];
                for (j = i - 1; j >= 0 && prices[j] > n; --j)
                    prices[j + 1] = prices[j];
                prices[j + 1] = n;
            }
            */
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
        /* Greedy Florist */
        public int getMinimumCost(int k, int[] c)
        {
            int flowerCount = c.Length;
            int total = 0;

            if (k >= flowerCount)
            {
                total = c.Sum();
                return total;
            }
            else
            {
                Array.Sort(c);
                Array.Reverse(c);
                int extraFee = 1;
                int normalPriceCount = k;
                for (int i = 0; i < c.Length; i++)
                {
                    if (normalPriceCount > 0)
                    {
                        total += c[i];
                        normalPriceCount--;
                    }
                    else
                    {
                        total += (extraFee + 1) * c[i];

                        if ((k - i - 1) % k == 0)
                        {
                            extraFee += 1;
                        }
                    }
                }
            }
            return total;
        }

    }
}