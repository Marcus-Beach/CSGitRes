using System;

namespace DailyCodingProblem
{
    class Program2
    {
        //From https://www.dailycodingproblem.com/
        //Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
        //For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. 
        //If our input was[3, 2, 1], the expected output would be[2, 3, 6].
        //Follow-up: what if you can't use division?
        static void Main(string[] args)
        {
            int arraySize = randomInt(6);
            int number = randomInt(6);
            int[] numArray = new int[arraySize];
            string sArray = "";
            string sArray2 = "";
            for (int i = 0; i < arraySize; i++)
            {
                numArray[i] = randomInt(number);
                sArray += numArray[i].ToString() + " ";
            }
            int[] numArray2 = buildArray(numArray);
            for (int i = 0; i < arraySize; i++)
            {
                sArray2 += numArray2[i].ToString() + " ";
            }
            Console.WriteLine("Number: " + number +
                                "\nArray Size: " + arraySize +
                                "\nArray: " + sArray +
                                "\nArray2: " + sArray2);

        }


        static int[] buildArray(int[] inArray)
        {
            int[] outArray = new int[inArray.Length];
            for (int i = 0; i < inArray.Length; i++)
            {
                outArray[i] = 0;
            }
            for (int i = 0; i < inArray.Length; i++)
            {
                for(int j = 0; j < inArray.Length; j++)
                {
                    if(i != j)
                    {
                        if(outArray[i] == 0)
                        {
                            outArray[i] = inArray[j];
                        }
                        else
                        {
                            outArray[i] *= inArray[j];
                        }  
                    }
                }
            }
            return outArray;
        }

        static int randomInt(int max)
        {
            Random rnd = new Random();
            return (int)(Math.Ceiling(rnd.NextDouble() * max));
        }
    }
}
