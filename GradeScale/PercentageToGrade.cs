using System;

namespace GradeScale
{
    public class PercentageToGrade:IPercentageToGrade
    {
        public int ToGrade(int percentage)
        {
            int grade;
            if (percentage > 100)
            {
                throw InvalidOperationException("Percentage is above 100");
            }

            if (percentage < 0)
            {
                throw InvalidOperationException("Percentage is bellow 100");
            }
            else
            {
                if (percentage >= 0 && percentage <= 7)
                {
                    grade = -3;
                }
                if (percentage >= 8 && percentage <= 33)
                {
                    grade = 00;
                }
                if (percentage >= 34 && percentage <= 41)
                {
                    grade = 02;
                }
                if (percentage >= 42 && percentage <= 57)
                {
                    grade = 4;
                }
                if (percentage >= 58 && percentage <= 77)
                {
                    grade = 7;
                }
                if (percentage >= 78 && percentage <= 89)
                {
                    grade = 10;
                }
                if (percentage >= 90 && percentage <= 100)
                {
                    grade = 12;
                }
            }

            return grade;
        }
    }
}