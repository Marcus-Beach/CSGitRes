using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class DateTimeExamples
    {
        static void Main(string[] args)
        {
            DateTime thisDate = DateTime.Now;
            int days = GetDaysTillChristmas(thisDate);
            Console.WriteLine(days);

            DateTime dt1 = CreateDate();
            DateTime dt2 = CreateDate();

            Console.WriteLine("Date difference of " + dt1 + " from " + dt2 + " is " + (int)dt1.Subtract(dt2).TotalDays + " days.");
        }

        static int GetDaysTillChristmas(DateTime dt)
        {
            DateTime christmas = CreateDate();
            TimeSpan days = christmas.Subtract(dt);
            return (int)days.TotalDays;
        }

        static DateTime CreateDate()
        {
            Console.WriteLine("Enter a date with format mm/dd/yyyy");
            string[] dateString = Console.ReadLine().Split("/");
            DateTime retDate = new DateTime(Int32.Parse(dateString[2]), Int32.Parse(dateString[0]), Int32.Parse(dateString[1]));
            return retDate;
        }
    }
}
