using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLargest, nSmallest, nCurrent;
            string input=" ";
            Console.WriteLine("Enter integers until you want to quit then enter \"Q\"");

            input = Console.ReadLine();
            if ((input == "Q") || (input == "q")) { return; }
            nCurrent = Convert.ToInt32(input);
            nLargest = nCurrent;
            nSmallest = nCurrent;
            while (input != "Q" && input != "q")
            {
                nCurrent = Convert.ToInt32(input);
                if (nCurrent < nSmallest) { nSmallest = nCurrent; }
                if (nCurrent > nLargest) { nLargest = nCurrent; }
                input = Console.ReadLine();
            }

            Console.WriteLine("Largest Value Entered: " + nLargest +
                              "\nSmallest Value Entered: " + nSmallest);

            Console.ReadLine();


        }
    }
}
