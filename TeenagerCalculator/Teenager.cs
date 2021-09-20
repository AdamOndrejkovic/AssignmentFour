using System;

namespace TeenagerCalculator
{
    public class Teenager:ITeenager
    {
        public bool IsTeenager(DateTime birthday)
        {
            int year = DateTime.Now.Year;
            int age = year - birthday.Year;

            if (age > 120 )
            {
                throw new InvalidOperationException("Sorry dude you are too old to be teenager");
            }
            if (year < birthday.Year)
            {
                throw new InvalidOperationException("You don't even exist yet.");
            }

            if (age is <= 19 and >= 13)
            {
                return true;
            }

            return false;
        }
    }
}