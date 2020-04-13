using System;

namespace hr.Easy.Mini_Max_Sum
{
    public class Mini_Max_Sum
    {
        static void miniMaxSum(int[] arr)
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
    }
}