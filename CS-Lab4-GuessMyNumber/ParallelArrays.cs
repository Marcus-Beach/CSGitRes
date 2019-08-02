using System;

namespace CS_Lab4_GuessMyNumber
{
    class ParallelArrays
    {
        static void Main(string[] args)
        {
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;

            Console.WriteLine("Type a name to search for in the phone book:");
            strSearch = Console.ReadLine();

            for (int i = 0; i < Names.Length; i++)
            {
                if(Names[i].IndexOf(strSearch) > -1)
                {
                    Console.WriteLine(Names[i] + " -> " + Phone[i]);
                }
            }

            Console.ReadLine();
        }

    }
}