using System;

namespace MakingChange
{
    class Program
    {
        // project for making change assignment
        static void Main(string[] args) 
        {
            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price + 1, (int)price + rnd.Next(5) + 1);
                string change = MakingChange(tendered - price);
                Console.WriteLine("Tendered: " + tendered + " total " + price + ". " + change);
                Console.Write("Type x to stop ");
                exit = Console.ReadLine();
            }
        }

        static string MakingChange(decimal amount)
        {
            string changeDue = "";
            int dollars, quarters, dimes, nickels, cents;
            dollars = Convert.ToInt32(Math.Floor(amount));
            int num = Convert.ToInt32((amount * 100) - (dollars * 100));
            quarters = (num - (num % 25)) / 25;
            num = num % 25;
            dimes = (num - (num % 10)) / 10;
            num = num % 10;
            nickels = (num - (num % 5)) / 5;
            cents = num % 5;

            changeDue = "Change due: ";
            int[] amountArray = new int[5];
            amountArray[0] = dollars;
            amountArray[1] = quarters;
            amountArray[2] = dimes;
            amountArray[3] = nickels;
            amountArray[4] = cents;
            string[] curArray = { "Dollar", "Quarter", "Dime", "Nickel", "Cent" };

            for (int i = 0; i < amountArray.Length; i++)
            {
                if(amountArray[i] > 0)
                {
                    int lead = 0, trail = 0;
                    for (int j = 0; j < i; j++)
                    {
                        lead += amountArray[j];
                    }
                    for (int j = (amountArray.Length - 1); j > i; j--)
                    {
                        trail += amountArray[j];
                    }
                    if (i < amountArray.Length && lead > 0)
                    {
                        changeDue = changeDue + ", ";
                        if (i < amountArray.Length && trail == 0)
                        {
                            changeDue += "and ";
                        }
                    }
                    changeDue = changeDue + amountArray[i] + " " + curArray[i];
                    if(amountArray[i] > 1)
                    {
                        changeDue += "s";
                    }
                }
            }

            return changeDue;
        }
    }
}
