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

        //create a method to add two numbers
        static int Add(int num1, int num2)
        {
            return num1+num2;
        }

        //create method to create the full name of a student given first last and middle name

        static string creStuName(string first, string last, string middle)
        {
            return first + " " + middle + " " + last;
        }

        //create a days until method it has one parameter the holiday

            /*
        static int DaysUntil(string Holiday)
        {
            DateTime date;
            DateTime Today = DateTime.Now;
            switch(Holiday)
            {
                case "Christmas":
                    date = new DateTime(Today.Year, 12, 25);
                case "new years":
                    date = new DateTime(Today.Year, 1, 1);
                case "Halloween":
                    date = new DateTime(Today.Year, 10, 31);
                case "independance day":
                    date = new DateTime(Today.Year, 7, 4);
                case "boxing day":
                    date = new DateTime(Today.Year, 12, 26);
                case "labor day":
                    date = new DateTime(Today.Year, 12, 25);
                default:
                    return 0;
            }
        }

        */



        static string GetMarcusName()
        {
            return "Marcus";
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
