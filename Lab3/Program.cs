using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare vars
            double dblHeight, dblWeight, dblBMI;
            Console.WriteLine("Enter Subject Height in inches");
            //dblHeight = Convert.ToDouble(Console.ReadLine());
            while(!double.TryParse(Console.ReadLine(), out dblHeight) || dblHeight <0)
            {
                Console.WriteLine("Not Valid. Must be a positive rational number.");
            }
            Console.WriteLine("Enter Subject Weight in pounds");
            //dblWeight = Convert.ToDouble(Console.ReadLine());
            while (!double.TryParse(Console.ReadLine(), out dblWeight) || dblWeight < 0)
            {
                Console.WriteLine("Not Valid. Must be a positive rational number.");
            }

            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);
            Console.WriteLine("Subject BMI is " + dblBMI);
            if (dblBMI < 18.5) { Console.WriteLine("BMI < 18.5 - Underweight"); }
            else if (dblBMI < 25) { Console.WriteLine("BMI between 18.5 and 24.9 - Normal"); }
            else if (dblBMI < 30) { Console.WriteLine("BMI between 25 and 29.9 - Overweight"); }
            else { Console.WriteLine("BMI >= 30 - Obese"); }

            Console.ReadLine();

        }
    }
}
