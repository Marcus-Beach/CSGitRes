using System;

namespace CS_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int choice;
            Console.WriteLine("Select Program \n" +
                              "1. Compare 2 numbers and display larger" +
                              "\n2. Compare 3 numbers and display largest and smallest");

            choice = GetChoice();

            if (choice == 1) { Prog1(); }
            else if (choice == 2) { Prog2(); }
            else { Console.WriteLine("Error: Got invalid choice" + choice); }
            
        }

        static int GetChoice()
        {
            int num, goodChoice;
            goodChoice = 0;
            num = 0;
            while (goodChoice == 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if ((num < 1) || (num > 2))
                {
                    Console.WriteLine("Invalid input.  Must enter 1 or 2.");
                }
                else { goodChoice = num; }
            }
            return goodChoice;
        }

        static void Prog1()
        {
            int[] numArray = new int[2];
            int i;
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter number " + (i+1));
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numArray);
            Console.WriteLine("Larger Number is " + numArray[1]);

            return;
        }
        static void Prog2()
        {
            int[] numArray = new int[3];
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number " + (i+1));
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numArray);
            Console.WriteLine("Largest Number is " + numArray[2] +
                              "\nSmallest Number is " + numArray[0]);

            return;
        }
    }
}
