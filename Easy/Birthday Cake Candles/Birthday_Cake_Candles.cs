namespace hr.Easy.Birthday_Cake_Candles
{
    public class Birthday_Cake_Candles
    {
        public static int birthdayCakeCandles(int[] ar)
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
    }
}