using System;

namespace GradeScale
{
    public class PercentageToGrade : IPercentageToGrade
    {
        public int ToGrade(int percentage)
        {
            if (percentage > 100)
            {
                throw new InvalidOperationException("Percentage is above 100");
            }

            if (percentage < 0)
            {
                throw new InvalidOperationException("Percentage is bellow 0");
            }
            int grade = 0;
            if (percentage >= 0 && percentage <= 7)
            {
                grade = -3;
            }

            else if (percentage <= 33)
            {
                grade = 00;
            }

            else if (percentage <= 41)
            {
                grade = 02;
            }

            else if (percentage <= 57)
            {
                grade = 4;
            }

            else if (percentage <= 77)
            {
                grade = 7;
            }

            else if (percentage <= 89)
            {
                grade = 10;
            }

            else if (percentage <= 100)
            {
                grade = 12;
            }

            return grade;
        }
    }
}