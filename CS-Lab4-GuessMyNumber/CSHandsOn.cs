using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class CSHandsOn
    {
        static void Main()
        {
            int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
            int[] array2 = { -9, -7 - 8, -11, -7, -88, -5, -10 };
            Console.WriteLine(FindMax(array1));
            Console.WriteLine(FindMax(array2));
            string[] arrayX = { "AAAAA", "BBBB", "CCC", "DD", "E" };
            string[] arrayY = { "Texas", "New York", "Washington", "Nevada" };
            string[] arrayA = ReverseArray(arrayX);
            string[] arrayB = ReverseArray(arrayY);
            for (int i = 0; i < arrayX.Length; i++)
            {
                Console.WriteLine(arrayX[i] + "\t" + arrayA[i]);
            }
            for (int i = 0; i < arrayY.Length; i++)
            {
                Console.WriteLine(arrayY[i] + "\t" + arrayB[i]);
            }
            double tempInput = 0;
            while (tempInput != -40)
            {
                tempInput = GetNumber("Enter a temperature to convert. -40 to end: ");
                Console.WriteLine("Celcius " + tempInput + " to Fahrenheit " + ConvertTemp("CtoF", tempInput));
                Console.WriteLine("Fahrenheit " + tempInput + " to Celcius " + ConvertTemp("FtoC", tempInput));
            }

        }
        //1. find max
        static int FindMax(int[] array)
        {
            int[] sortArray = new int[array.Length];
            array.CopyTo(sortArray, 0);
            Array.Sort(sortArray);
            return sortArray[(sortArray.Length - 1)];
        }

        //2. Reverse an array
        static string[] ReverseArray(string[] array)
        {
            string[] sortArray = new string[array.Length];
            array.CopyTo(sortArray, 0);
            for (int i = 0; i < (sortArray.Length / 2); i++)
            {
                string hold = sortArray[i];
                sortArray[i] = sortArray[sortArray.Length - (i + 1)];
                sortArray[sortArray.Length - (i + 1)] = hold;
            }
            return sortArray;
        }

        //3. Convert temperature
        static double ConvertTemp(string convertTo, double temperature)
        {
            double cTemp = -999999;
            if (convertTo == "CtoF")
            {
                cTemp = (temperature * 9) / 5 + 32;
            }
            if (convertTo == "FtoC")
            {
                cTemp = ((temperature - 32) * 5) / 9;
            }
            return cTemp;
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
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
    }
}
