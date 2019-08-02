using System;

namespace CS_Lab4_GuessMyNumber
{
    class PracticeWithLoops
    {
        static void Main(string[] args)
        {
            
            // Find the Max and Min of an Array
            Console.WriteLine("Min and Max Example");
            int[] minMax = getArray();
            Array.Sort(minMax);
            Console.WriteLine("Minimum Number is " + minMax[0] + "\n" +
                              "Maximum Number is " + minMax[(minMax.Length - 1)]);
            // Get an array and reverse it
            Console.WriteLine("Reverse Example");
            int[] reverse = getArray();
            Console.WriteLine("Your array backwards is:");
            for (int i = (reverse.Length - 1); i > 0; i--)
            {
                Console.Write(reverse[i] + " , ");
            }
            Console.Write(reverse[0] + "\n");
            
            // Palindrome validator
            Console.WriteLine("Palindrome Example");
            Console.Write("Please enter a word: ");
            string palTest = Console.ReadLine();
            bool isPal = true;
            for (int i = 0; i < (palTest.Length / 2); i++)
            {
                if (palTest[i] != palTest[(palTest.Length - i - 1)])
                {
                    isPal = false;
                    break;
                }
            }
            if (isPal) { Console.WriteLine("This word is a palindrome."); }
            else { Console.WriteLine("This word is not a palindrome."); }
        }

        static int[] getArray() //returns an array of ints
        {
            int ArraySize = GetNumber("Please enter how many numbers you want in your array: ");
            int[] newArray = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                newArray[i] = GetNumber("Please enter the value for number " + (i + 1) + ": ");
            }
            return newArray;

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