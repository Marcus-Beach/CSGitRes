using System;

namespace CS_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double dub1, dub2;
            Console.WriteLine("Enter Integer 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Integer 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            dub1 = num1;
            dub2 = num2;
            
            Console.WriteLine("Sum: " + (dub1 + dub2) +
                              "\nProduct: " + (dub1 * dub2) +
                              "\nDifference: " + (dub1 - dub2) +
                              "\nQuotient: " + (dub1 / dub2));
        }
    }
}
