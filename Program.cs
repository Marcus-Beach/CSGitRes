using System;

namespace DailyCodingProblem
{
    class Program
    {
        //From https://www.dailycodingproblem.com/
        //Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        //For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        //Bonus: Can you do this in one pass?
        static void Main(string[] args)
        {
            int arraySize = randomInt(20);
            int number = randomInt(20);
            int[] numArray = new int[arraySize];
            string sArray = "";
            for(int i = 0; i < arraySize; i++)
            {
                numArray[i] = randomInt((number * 2));
                sArray += numArray[i].ToString() + " ";
            }
            Console.WriteLine("Number: " + number +
                                "\nArray Size: " + arraySize +
                                "\nArray: " + sArray +
                                "\nPair: " + isPair(number, numArray));

        }

        static bool isPair(int num, int[] numlist)
        {
            bool[] there = new bool[(num + 1)];
            for(int i = 0; i < numlist.Length; i++)
            {
                if(numlist[i] <= num)
                {
                    if (there[(num - numlist[i])])
                    {
                        return true;
                    }
                    there[numlist[i]] = true;
                }
            }
            return false;
        }

        static int randomInt(int max)
        {
            Random rnd = new Random();
            return (int)(Math.Ceiling(rnd.NextDouble() * max));
        }
    }
}
