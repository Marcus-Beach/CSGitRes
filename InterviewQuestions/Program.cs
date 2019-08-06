using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> match = new List<string>();
            int count = match.Count;
            while (true)
            {
                int choice = GetNumber("1. Exit\n" +
                                       "2. A-D Numbered Array Examples\n" +
                                       "3. E Given an array of strings find the longest string.\n" +
                                       "4. F Given a string create an array of the words in the string.\n" +
                                       "5. G Given a number print a square with that as the length and width of the sides\n" +
                                       "6. H Given a number print a tree shape.\n" +
                                       "7. I Given a string convert to an array words print words within a box.\n" +
                                       "8. J Given a string with a person’s name return a string of their initials\n" +
                                       "9. K Given two numbers, find the largest, print the numbers from max to min.\n" +
                                       "10. L Given a string print the individual characters front to back and back to front.\n" +
                                       "11. M Given a string reverse it..ti esrever gnirts a neviG\n" +
                                       "12. N Given a string capitalize each word and print out.\n" +
                                       "13. Same Letter Pattern.\n" +
                                       ": ", 13, 1);
                switch (choice)
                {
                    default:
                        Console.WriteLine("Invalid input, exiting");
                        return;
                    case 1:
                        Console.WriteLine("Have a Nice Day");
                        return;
                    case 2:
                        Console.Clear();
                        MinMaxAvg();
                        break;
                    case 3:
                        Console.Clear();
                        LongestString();
                        break;
                    case 4:
                        Console.Clear();
                        StringToArray();
                        break;
                    case 5:
                        Console.Clear();
                        MakeBox();
                        break;
                    case 6:
                        Console.Clear();
                        PrintTree();
                        break;
                    case 7:
                        Console.Clear();
                        BoxString();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine(Initials(GetInput("Enter a Name: ")));
                        break;
                    case 9:
                        Console.Clear();
                        Numbers(GetNumber("Enter Number 1: "), GetNumber("Enter Number 2: "));
                        break;
                    case 10:
                        Console.Clear();
                        Mirror();
                        break;
                    case 11:
                        Console.Clear();
                        Reverse();
                        break;
                    case 12:
                        Console.Clear();
                        LeadCap();
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine(SameLetterPattern(GetInput("Enter String 1: "), GetInput("Enter String 2: ")).ToString()); 
                        break;
                }
            }
        }

        //  A.	Given an array of integers find the largest, smallest average.
        //  B.	Given an array of integers find the second largest and the second smallest.
        //  C.	Given an array of integers return the total of all values.
        //  D.	Given an array of integers return count of numbers > some value.
        static void MinMaxAvg()
        {
            int min = 0, max = 0, total = 0, average = 0;
            int smin = 0, smax = 0;
            int count = 0;
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
            Console.WriteLine("Array values: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
                if (i > average) count++;
            }
            Console.WriteLine("");
            Console.WriteLine("Min:\t\t" + min +
                              "\nMax:\t\t" + max +
                              "\nSecond Min:\t" + smin +
                              "\nSecond Max:\t" + smax +
                              "\nTotal:\t\t" + total +
                              "\nAverage:\t" + average +
                              "\nNumbers greater than " + average + ": " + count);
        }

        //E.	Given an array of strings find the longest string.
        static void LongestString()
        {
            string longest = "";
            string[] stringArray = new string[5];
            stringArray[0] = "A short string.";
            stringArray[1] = "A medium length string.";
            stringArray[2] = "A longer length string that is long.";
            stringArray[3] = "A string that is much longer than the other strings in the array.";
            stringArray[4] = "A not to long string.";
            Console.WriteLine("String array: ");
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
                if (s.Length <= longest.Length) longest = s;
            }
            Console.WriteLine("The longest string is \n\"" + longest + "\"");
        }

        //F.	Given a string create an array of the words in the string.
        static void StringToArray()
        {
            string input = GetInput("Enter a string to be converted to an array: \n");
            string[] stringArray = input.Split(" ");
            Console.WriteLine("Showing string split into an array");
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }
        }

        //G.	Given a number print a square with that as the length and width of the sides.
        //* * * * * *       int side = 6;
        //*         *
        //*         *
        //*         *
        //*         *
        //* * * * * *
        static void MakeBox()
        {
            int boxSize = GetNumber("Enter Box Size: ");
            for (int i = 0; i < boxSize; i++)
            {
                for (int j = 0; j < boxSize; j++)
                {
                    if (i == 0 || i == (boxSize - 1) || j == 0 || j == (boxSize - 1))
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        //H.	Given a number print a tree shape.
        //    *       int howTall = 4;
        //   ***
        //  *****
        // *******
        static void PrintTree()
        {
            int howTall = GetNumber("Enter the height of the tree: ");
            for (int i = 0; i < howTall; i++)
            {
                for (int j = 0; j < (howTall * 2); j++)
                {
                    if (j < (howTall - i) || j > (howTall + i))
                    {
                        Console.Write(" ");
                    }
                    else Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        //I.	Given a string convert to an array words print words within a box.
        //*********       String str = “Let’s do this!;
        //* Let’s*
        //* do    *		// create word array to determine number of rows
        //* this! *		// find the longest string to determine width
        //*********
        static void BoxString()
        {
            string sentance = GetInput("Enter a sentance to box.\n"); //grab the sentance
            string[] words = sentance.Split(" "); //split it into words
            string word = "";
            int max = 0;
            foreach (string w in words) //find the biggest word
            {
                if (w.Length > max) max = w.Length;
            }
            List<string> preBox = new List<string>();
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            while (words.Length > max && max > 0) //square up the sentance, run until array length is less than max line size
            {
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine("Processing " + words[i] + " index " + i);
                    if (word.Length >= max) // handle word is greater than max
                    {
                        Console.WriteLine("Adding " + word);
                        preBox.Add(word);
                        word = "";
                    }
                    else if (word.Length < max && word == "") //when word is empty and array line is less than biggest word
                    {
                        word = words[i];
                    }
                    else if (word.Length < max && word != "") //when word is not empty and line is less than biggest word
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
                if (i == 0) // write top of box
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
                if (i == (words.Length - 1)) //write bottom of box
                {
                    for (int j = 0; j < (max + 2); j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }

        //J.	Given a string with a person’s name return a string of their initials
        static string Initials(string name) 
        {
            string initials = "";
            string[] names = name.Split(" ");  //split the name up
            foreach (string n in names) //run through the names
            {
                initials += n[0].ToString().ToUpper() + "."; //grab first letter of each word, uppercase it, and add it with a .
            }
            return initials; // return the initial string
        }

        //K.	Given two numbers, find the largest, print the numbers from max to min.
        static void Numbers(int num1, int num2)  //just used the ternary operator in a writeline
        {
            Console.WriteLine("Largest number is " + (num1 > num2 ? num1 : num2) + 
                              ".  Numbers from Max to Min " + (num1 > num2 ? num1 : num2) + " " +
                              (num1 < num2 ? num1 : num2));
        }
        //L.	Given a string print the individual characters front to back and back to front.
        static void Mirror()  // wasn't sure what the point of this one was so printed them out side by side
        {
            string input = GetInput("Enter a string: \n");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " " + input[((input.Length - 1) - i)]);
            }
        }
        //M.	Given a string reverse it..ti esrever gnirts a neviG
        static void Reverse() //dumps the reversed version into a string and prints it.
        {
            string input = GetInput("Enter a string: \n");
            string reverse = "";
            for (int i = (input.Length - 1); i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(input + reverse);
        }
        //N.	Given a string capitalize each word and print out.
        static void LeadCap()
        {
            string input = GetInput("Enter a string: \n");  //get the string
            string[] sArray = input.Split(" "); //split out the words
            string upLow = "";
            foreach(string s in sArray) // for each word add the uppercased lead character and the rest of the word and a space
            {
                upLow += s[0].ToString().ToUpper() + s.Substring(1).ToString() + " ";
            }
            Console.WriteLine(upLow.Trim().ToString()); //trim off the trailing space before printing it.
        }
        public static string GetInput(string prompt)  // pulled from Utils
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetNumber(string prompt) // pulled from Utils
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

        public static int GetNumber(string prompt, int max) // pulled from Utils
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

        public static int GetNumber(string prompt, int max, int min) // overloaded version added to handle min
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
        public static bool SameLetterPattern(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Failed at length match: " + str1.Length + " " + str2.Length);
                return false;
            }
            List<string> match = new List<string>();
            for (int i = 0; i < str1.Length; i++)
            {
                bool chMatch = false;
                if (match.Count == 0)
                {
                    match.Add(str1[i].ToString() + str2[i].ToString());
                }
                for (int j = 0; j < match.Count; j++)
                {
                    if (str1[i].ToString() == match[j].ToString()[0].ToString() &&
                        str2[i].ToString() != match[j].ToString()[1].ToString())
                    {
                        Console.WriteLine("Failed at pattern match: " + str1[i].ToString() + str2[i].ToString() + " " + match[j].ToString());
                        return false;
                    }
                    if (str1[i].ToString() == match[j].ToString()[0].ToString() &&
                        str2[i].ToString() == match[j].ToString()[1].ToString())
                    {
                        chMatch = true;
                    }
                }
                if (chMatch == false)
                {
                    match.Add(str1[i].ToString() + str2[i].ToString());
                }
            }
            return true;
        }

    }
}
