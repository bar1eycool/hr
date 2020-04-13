using System;
using System.Collections.Generic;
using hr.Medium.Greedy_Florist;
using hr.Medium.Mark_and_Toys;
using hr.Easy.Time_Conversion;
using hr.Easy.Birthday_Cake_Candles;
using hr.Easy.Mini_Max_Sum;
using hr.Easy.Grading_Students;

namespace hr
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Greedy Florist test cases */
            // Console.WriteLine(Greedy_Florist.getMinimumCost(3, new int[] { 390225, 426456, 688267, 800389, 990107, 439248, 240638, 15991, 874479, 568754, 729927, 980985,
            //  132244, 488186, 5037, 721765, 251885, 28458, 23710, 281490, 30935, 897665, 768945, 337228, 533277, 959855, 927447, 941485, 24242, 684459, 312855,
            //  716170, 512600, 608266, 779912, 950103, 211756, 665028, 642996, 262173, 789020, 932421, 390745, 433434, 350262, 463568, 668809, 305781, 815771,
            //  550800 }) == 163578911);
            // Console.WriteLine(Greedy_Florist.getMinimumCost(34, new int[] { 433515, 22221, 540709, 538312, 496949, 902471, 439983, 159332, 417327, 399306, 817804, 354682,
            //  108825, 970689, 868286, 235070, 18732, 848955, 994152, 741000, 722232, 564879, 503093, 734475, 174795, 129065, 483929, 683440, 37645, 670198, 911023,
            //  40334, 329513, 669160, 180034, 285512, 401190, 629798, 857703, 765572, 174164, 849299, 159367, 62467, 84449, 523962, 735995, 245666, 832139, 879827,
            //  749840, 315756, 253168, 659252, 187178 }) == 30352414);

            /* Mark and Toys test cases */
            // Console.WriteLine(Mark_and_Toys.maximumToys(new int[] { 1, 12, 5, 111, 200, 1000, 10 }, 50) == 4);

            /* Time Conversion test cases */
            // Console.WriteLine(Time_Conversion.timeConversion("07:05:45PM"));

            /* Birthday Cake Candles test cases */
            // Console.WriteLine(Birthday_Cake_Candles.birthdayCakeCandles(new int[] { 3, 2, 1, 3 }) == 2);

            /* Mini-Max Sum test cases */
            // Mini_Max_Sum.miniMaxSum(new int[] { 1, 2, 3, 4, 5 });

            /* Grading_Students test cases */
            List<int> li = new List<int>();
            li.Add(73);
            li.Add(67);
            li.Add(38);
            li.Add(33);
            Grading_Students.gradingStudents(li);
            Console.WriteLine("Hello World!");
        }
    }
}
