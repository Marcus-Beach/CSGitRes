using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class Utils
    {
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static float GetFloat(string prompt)
        {
            float num;
            Console.Write(prompt);
            do
            {
                if (float.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }

        public static int GetNumber(string prompt)
        {
            int num;
            Console.Write(prompt);
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }

        public static int GetNumber(string prompt, int max)
        {
            int num;
            do
            {
                num = GetNumber(prompt);
                if (num > max)
                {
                    Console.WriteLine("Number too large");
                }
            } while (num > max);
            return num;
        }

        public static int GetNumber(string prompt, int max, int min)
        {
            if(max < min)
            {
                Console.WriteLine("Error: invalid range max " + max + " < min " + min);
                return -1;
            }
            int num;
            do
            {
                num = GetNumber(prompt);
                if (num > max)
                {
                    Console.WriteLine("Number too large");
                }
                if (num < min)
                {
                    Console.WriteLine("Number too small");
                }
            } while (num > max || num < min);
            return num;
        }

        static void Main(string[] args)
        {
            string msg = GetInput("Enter a message: ");
            int max = GetNumber("Enter Max Number: ");
            int num = GetNumber("Enter Number < " + max + " ", max);
            float flt = GetFloat("Enter a Float: ");

            Console.WriteLine("You entered the following info : {0} - {1} - {2}", msg, num, flt);
        }
    }
}
