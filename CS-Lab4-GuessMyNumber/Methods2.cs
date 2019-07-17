using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class Methods2
    {
        static void Main(string[] args)
        {
            /*string hello;
            hello = WelcomeMessage("C#", "Marcus");
            Console.WriteLine(hello);*/
            DateTime thisDate = DateTime.Now;
            string day = GetDayOfWeek(thisDate);
            Console.WriteLine(thisDate.ToString() + " is a " + day);
        }

        static string GetDayOfWeek(DateTime dateTime)
        {
            string dayOfTheWeek;
            dayOfTheWeek = dateTime.DayOfWeek.ToString();
            return dayOfTheWeek;
        }

        static string WelcomeMessage (string course, string name)
        {
            string msg;
            msg = "Welcome " + name + " to " + course + " at Edge Tech Academy";
            return msg;
        }
    }
}
