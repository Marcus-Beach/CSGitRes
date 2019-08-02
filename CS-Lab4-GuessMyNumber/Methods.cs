using System;
// also include Utils class from Canvas

namespace CS_Lab4_GuessMyNumber //but actually lab 7?  And Lab4?  Starting to get confused at how this is working...
{
    class Methods
    {
        static void Main(string[] args)
        {           
            string Play = "Y"; // initialize just in case
            do // continue to play loop
            {
                int randomNumber = RandomNumber(1, 100); // get random number
                while (true) // guess response loop
                {
                    int guess = Utils.GetNumber("Enter number between 1 and 100: ", 100);

                    Console.Clear();
                    int highOrLow = PlayGame(randomNumber, guess);
                    if (highOrLow == 0)
                    {
                        Console.WriteLine("You win! Play again?");
                        break;
                    }
                    else if (highOrLow > 0)
                    {
                        Console.WriteLine("You guessed too high.");
                    }
                    else
                    {
                        Console.WriteLine("You guessed too low.");
                    }
                }
                Play = Console.ReadLine(); // grab the response
                Play = Play.ToUpper(); // normalise
                switch (Play) // use a switch because why not
                {
                    case "Y":
                        continue;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Invalid Input, Exiting Game");
                        break;
                }
            }
            while (Play == "Y");
        }
        static int RandomNumber(int min, int max) // RNG is fun!
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static int PlayGame(int SecNum, int Guess) // Hello Professor...
        {
            if(Guess > SecNum)
            {
                return 1;
            }
            else if (Guess == SecNum)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }  
}