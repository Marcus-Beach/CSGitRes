using System;
using System.Collections.Generic;

namespace More_Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("1. Exit\n2. Muliplication tables\n3. Spell-check\n4. Phone Numbers to Words");
                choice = GetNumber("Enter number of choice (1-4): ", 4, 1);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Have nice day.");
                        return;
                    case 2:
                        MultiplicationTables();
                        break;
                    case 3:
                        SpellCheck();
                        break;
                    case 4:
                        PhoneNumber();
                        break;
                    default:
                        Console.WriteLine("Invalid input error: choice outside option set");
                        return;
                }
            }

        }
        static void MultiplicationTables()
        {
            int num = GetNumber("Enter a number from 2 to 20: ", 20, 2);
            for (int i = 0; i <= num; i++)
            {
                if(i==0)
                {
                    Console.Write(" |0");
                }
                else Console.Write("\t" + i);
            }
            Console.Write("\n");
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <= num; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(i +"|0");
                    }
                    else Console.Write("\t" + (i*j));
                }
                Console.Write("\n");
            }
        }
        static void SpellCheck()
        {
            bool vowl = false, cons = false;
            string check = GetInput("Enter a string: ");
            if(check == "I" || check == "a" || check == "A")
            {
                Console.WriteLine(check + " is a word.");
                return;
            }
            if (check.Length < 2)
            {
                Console.WriteLine(check + " is not a word.");
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                if(check.Contains(i.ToString()))
                {
                    Console.WriteLine(check + " is not a word.");
                    return;
                }
            }
            for (int i = 0; i < check.Length; i++)
            {
                if(check[i].ToString() != check[i].ToString().ToLower() && i > 0)
                {
                    Console.WriteLine(check + " is not a word.");
                    return;
                }
                if(check[i].ToString().ToLower() == "a")
                {
                    vowl = true;
                }
                else if (check[i].ToString().ToLower() == "e")
                {
                    vowl = true;
                }
                else if (check[i].ToString().ToLower() == "i")
                {
                    vowl = true;
                }
                else if (check[i].ToString().ToLower() == "o")
                {
                    vowl = true;
                }
                else if (check[i].ToString().ToLower() == "u")
                {
                    vowl = true;
                }
                else if (check[i].ToString().ToLower() == "y")
                {
                    vowl = true;
                }
                else
                {
                    cons = true;
                }
            }
            if(vowl && cons)
            {
                Console.WriteLine(check + " is a word.");
                return;  
            }
            Console.WriteLine(check + " is not a word.");
            return;
        }

        static void PhoneNumber()
        {
            Dictionary<string, string> alphaPhone = new Dictionary<string, string>();
            alphaPhone.Add("A", "2");
            alphaPhone.Add("B", "2");
            alphaPhone.Add("C", "2");
            alphaPhone.Add("D", "3");
            alphaPhone.Add("E", "3");
            alphaPhone.Add("F", "3");
            alphaPhone.Add("G", "4");
            alphaPhone.Add("H", "4");
            alphaPhone.Add("I", "4");
            alphaPhone.Add("J", "5");
            alphaPhone.Add("K", "5");
            alphaPhone.Add("L", "5");
            alphaPhone.Add("M", "6");
            alphaPhone.Add("N", "6");
            alphaPhone.Add("O", "6");
            alphaPhone.Add("P", "7");
            alphaPhone.Add("Q", "7");
            alphaPhone.Add("R", "7");
            alphaPhone.Add("S", "7");
            alphaPhone.Add("T", "8");
            alphaPhone.Add("U", "8");
            alphaPhone.Add("V", "8");
            alphaPhone.Add("W", "9");
            alphaPhone.Add("X", "9");
            alphaPhone.Add("Y", "9");
            alphaPhone.Add("Z", "9");

            string letters = GetInput("Enter a phone number as letters: ");
            string numbers = "";
            string character;
            for (int i = 0; i < letters.Length; i++)
            {
                alphaPhone.TryGetValue(letters[i].ToString(), out character);
                if (((i + 1) % 3) == 0 && (i + 1) < letters.Length)
                {
                    if(alphaPhone.TryGetValue(letters[i].ToString(), out character))
                    {
                        numbers += character + "-";
                    }   
                }
                else numbers += character;
            }

            Console.WriteLine(numbers);
            return;
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
    }
}
