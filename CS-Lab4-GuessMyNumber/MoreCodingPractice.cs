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
                    if(i == 0 || i == (boxSize - 1) || j == 0 || j == (boxSize - 1))
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
            string sentance = GetInput("Enter a sentance to box.\n"); //grab the sentance
            string[] words = sentance.Split(" "); //split it into words
            string word = "";
            max = 0;
            foreach(string w in words) //find the biggest word
            {
                if (w.Length > max) max = w.Length;
            }
            List<string> preBox = new List<string>();
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
            while (words.Length > max && max > 0) //square up the sentance, run until array length is less than max line size
            {                
                for (int i = 0; i < words.Length; i++) 
                {
                    Console.WriteLine("Processing " + words[i] + " index " + i);
                    if(word.Length >= max) // handle word is greater than max
                    {
                        Console.WriteLine("Adding " + word);
                        preBox.Add(word);
                        word = "";
                    }
                    else if (word.Length < max && word == "") //when word is empty and array line is less than biggest word
                    {
                        word = words[i];
                    }
                    else if(word.Length < max && word != "") //when word is not empty and line is less than biggest word
                    {
                        word = word + " " + words[i];
                    }
                    if (word.Length >= max || i == (words.Length - 1)) // handle word is greater than max
                    {
                        Console.WriteLine("Adding " + word);
                        preBox.Add(word);
                        word = "";
                    }

                }
                words = preBox.ToArray(); // reset words to the list and clear  the list
                preBox.Clear();
                foreach (string w in words) //find the biggest word
                {
                    if (w.Length > max) max = w.Length;
                }
                foreach (string w in words)
                {
                    Console.WriteLine(w);
                }
            }
            foreach (string w in words) //find the biggest word
            {
                if (w.Length > max) max = w.Length;
            }
            Console.WriteLine("");
            string spaces = ""; //for holding empty space
            for (int i = 0; i < words.Length; i++)
            {
                if(i == 0) // write top of box
                {
                    for (int j = 0; j < (max + 2); j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                spaces = ""; // reset spaces
                for (int j = 0; j < (max - words[i].Length); j++) //get number of spaces
                {
                    spaces += " ";
                }
                Console.Write("*" + words[i] + spaces + "*\n"); //write line
                if(i == (words.Length - 1)) //write bottom of box
                {
                    for (int j = 0; j < (max + 2); j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
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
        