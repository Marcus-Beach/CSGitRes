using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class MoreCodingPractice
    {
        static void Main()
        {
            int min = 0, max = 0, total = 0, average = 0;
            int smin = 0, smax = 0;
            int[] array = { 5, 7, 8, 3, 9, 100, 27, 92, -10 };
            min = max = smin = smax = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
                total += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smin && array[i] > min)
                {
                    smin = array[i];
                }
                if (array[i] > smax && array[i] < max)
                {
                    smax = array[i];
                }
            }
            average = total / array.Length;

            Console.WriteLine("Min:\t\t" + min +
                              "\nMax:\t\t" + max +
                              "\nSecond Min:\t" + smin +
                              "\nSecond Max:\t" + smax +
                              "\nTotal:\t\t" + total +
                              "\nAverage:\t" + average);

            int boxSize = GetNumber("Enter Box Size: ");
            for (int i = 0; i < boxSize; i++)
            {
                for (int j = 0; j < boxSize; j++)
                {

                }
            }
            string sentance = GetInput("Enter a sentance to box."); //grab the sentance
            string[] words = sentance.Split(" "); //split it into words
            string word = "";
            max = 0;
            foreach(string w in words) //find the biggest word
            {
                if (w.Length > max) max = w.Length;
            }
            List<string> preBox = new List<string>();
            while (words.Length > max && max <= 0) //square up the sentance
            {                
                for (int i = 0; i < words.Length; i++) 
                {
                    if (word.Length < max && word == "")
                    {
                        word = words[i];
                    }
                    else if(word.Length < max && word != "")
                    {
                        word = word + " " + words[i];
                    }
                    else
                    {
                        preBox.Add(word);
                        word = "";
                    }
                }
                words = preBox.ToArray();
                preBox.Clear();
            }

        }
        
        


        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }   // end of the GetInput method

        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }   // end of the GetNumber method
    }
}
        