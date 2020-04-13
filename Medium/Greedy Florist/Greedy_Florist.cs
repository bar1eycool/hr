using System;
using System.Linq;

namespace hr.Medium.Greedy_Florist
{
    public class Greedy_Florist
    {
        // Complete the getMinimumCost function below.
        public static int getMinimumCost(int k, int[] c)
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