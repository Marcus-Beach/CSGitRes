using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class NTT
    {
        static void Main()
        {
            while(true)
            {
                int num = GetNumber("Enter a number between 0 and 20: ", 20, 0);
                Console.WriteLine(num + " " + NumberToText(num));
                if (num == 0) break;
            }
        }

        static string NumberToText(int num)
        {
            if (num > 20 || num < 0)
            {
                return "Number " + num + " is out of method range 0-20";
            }
            // return num.ToString(); // <- this can't be the answer because that's too easy and thus it must be a trick question
            switch(num)
            {
                default:
                    return "unhandled input" + num;
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                case 20:
                    return "twenty";
            }
        }

        static int GetNumber(string prompt)
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

        static int GetNumber(string prompt, int max)
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

        static int GetNumber(string prompt, int max, int min)
        {
            if (max < min)
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

        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }    
}