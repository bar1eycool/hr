using System;
using System.Linq;

namespace hr.Easy.Time_Conversion
{
    public class Time_Conversion
    {
        public static string timeConversion(string s)
        {
            DateTime parsedDate = DateTime.Parse(s);
            return parsedDate.ToString("HH:mm:ss");
        }
    }
}