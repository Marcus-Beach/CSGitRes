using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> aList = new List<string>();
            SortedSet<string> aSet = new SortedSet<string>();
            string input, choice; //string to capture input
            int j = 0; //counter
            string[] listArray;
            string[] setArray;
            string buffer;
            int inputSize = 0;
            /*
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Input string or blank to end (" + j + " items so far:");
                input = Console.ReadLine();

                if (input != "")
                {
                    aList.Add(input);
                    aSet.Add(input);
                    j++;
                }
                else break;
            }

            listArray = aList.ToArray();
            setArray = new string[aSet.Count];
            aSet.CopyTo(setArray);

            for (int i = 0; i < setArray.Length; i++)
            {
                if (setArray[i].Length > inputSize) inputSize = setArray[i].Length;
            }

            for (int i = 0; i < listArray.Length; i++)
            {
                buffer = "";

                for (int k = 0; k < ((inputSize - listArray[i].Length) / 8) + 1; k++)
                {
                    buffer = buffer + "\t";
                }
                if (i < setArray.Length)
                {
                    Console.WriteLine(listArray[i] + buffer + setArray[i]);
                }
                else Console.WriteLine(listArray[i]);
            }

            while (true)
            {
                Console.WriteLine("Input string to find or blank to end (" + j + " items :");
                input = Console.ReadLine();
                Console.Clear();
                if (input != "")
                {
                    if (aList.Contains(input))
                    {
                        Console.WriteLine(input + " is at index " + aList.IndexOf(input) + " and set " +
                            (aSet.Contains(input) ? "contains " : "does not contain ") + input);
                    }
                    else Console.WriteLine(input + " isn't there.");
                }
                else break;
            }
            */
            while (true)
            {
                Console.WriteLine("1. Exit\n2. Delete\n3. Display\n4. Add\n5. Find\n");
                choice = Console.ReadLine();
                if (choice == "1") break;
                Console.Clear();

                switch (choice)
                {
                    default:
                        Console.WriteLine("I don't know how to do that.");
                        break;
                    case "2":
                        Console.WriteLine("What do you want to remove?\n");
                        input = Console.ReadLine();
                        aList.Remove(input);
                        aSet.Remove(input);
                        break;
                    case "3":
                        listArray = aList.ToArray();
                        setArray = new string[aSet.Count];
                        aSet.CopyTo(setArray);
                        inputSize = 0;

                        for (int i = 0; i < setArray.Length; i++)
                        {
                            if (setArray[i].Length > inputSize) inputSize = setArray[i].Length;
                        }

                        for (int i = 0; i < listArray.Length; i++)
                        {
                            buffer = "";

                            for (int k = 0; k < ((inputSize - listArray[i].Length) / 8) + 1; k++)
                            {
                                buffer = buffer + "\t";
                            }
                            if (i < setArray.Length)
                            {
                                Console.WriteLine(listArray[i] + buffer + setArray[i]);
                            }
                            else Console.WriteLine(listArray[i]);
                        }
                        break;
                    case "4":
                        while (true)
                        {
                            Console.WriteLine("Input string or blank to end");
                            input = Console.ReadLine();
                            Console.Clear();
                            if (input != "")
                            {
                                aList.Add(input);
                                aSet.Add(input);
                                j++;
                            }
                            else break;
                        }
                        break;
                    case "5":
                        while (true)
                        {
                            Console.WriteLine("Input string to find or blank to end");
                            input = Console.ReadLine();
                            Console.Clear();
                            if (input != "")
                            {
                                if (aList.Contains(input))
                                {
                                    Console.WriteLine(input + " is at index " + aList.IndexOf(input) + " and set " +
                                        (aSet.Contains(input) ? "contains " : "does not contain ") + input);
                                }
                                else Console.WriteLine(input + " isn't there.");
                            }
                            else break;
                        }
                        break;
                }


            }
        }
    }
}
