using System;

namespace CS_HW2_GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, remainder;
            Console.WriteLine("Enter Number 1");
            while(!int.TryParse(Console.ReadLine(),out num1) || num1 < 0)
            {
                Console.WriteLine("Invalid Number, must be positive integer.");
            }

            Console.WriteLine("Enter Number 2");
            while (!int.TryParse(Console.ReadLine(), out num2) || num2 < 0)
            {
                Console.WriteLine("Invalid Number, must be positive integer.");
            }
            if(num1 > num2) { remainder = num1; num1 = num2; num2 = remainder; }
            remainder = num2 % num1;
            while (remainder != 0)
            {
                num2 = num1;
                num1 = remainder;
                remainder = num2 % num1;
            }
            Console.WriteLine("GCD is " + num1);
        }
    }
}
