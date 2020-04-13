using System;
using System.Collections;
using System.Collections.Generic;

namespace hr.Easy.Grading_Students
{
    public class Grading_Students
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            for (var i = 0; i < grades.Count; i++) {
                if ((grades[i] >= 38) && ((5 - grades[i] % 5) < 3)) {
                    grades[i] += (5 - grades[i] % 5);
                    Console.WriteLine(grades[i]);
                }
            }
            return grades;
        }
    }
}