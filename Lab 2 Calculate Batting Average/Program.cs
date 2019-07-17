/*
Project:    Lab 2 Calculate Batting Average
Date:       07/11/2019
Author:     Marcus Beach
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

using System;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPlayerName;
            double dblHits, dblAtBats;
            double dblBattingAverage;

            //prompt for name and receive
            Console.WriteLine("~This program calculates a baseball player's batting average~");
            Console.WriteLine("<---------------------------------------------------------->~");
            Console.WriteLine("");
            Console.WriteLine("Enter the player's name");
            strPlayerName = Console.ReadLine();

            //prompt for hits and at bats
            Console.WriteLine("Enter the player's # of hits: ");
            dblHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats: ");
            dblAtBats = Convert.ToInt32(Console.ReadLine());

            dblBattingAverage = (dblHits / dblAtBats);

            Console.WriteLine(strPlayerName + "'s batting average is " + (dblBattingAverage*100) + "%");
            Console.ReadLine();
        }
    }
}
