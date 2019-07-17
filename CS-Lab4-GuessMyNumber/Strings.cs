using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab4_GuessMyNumber
{
    class Strings
    {
        static void Main(string[] args)
        {
            FunWithStrings();
            Console.ReadLine();
            FunWithFormats();
        }
        private static void FunWithStrings()
        {
            string name = "Edge Tech Academy";
            Console.WriteLine("My name is '" + name + "' and it is " + name.Length + " characters long");

            bool hasTech = name.Contains("Tech");
            Console.WriteLine("Does my name contain Tech? " + (hasTech ? "Why yes is does!" : "No Tech :-("));

            bool isBoring = name.Contains("boring stuff");
            Console.WriteLine("Does my name contain 'boring stuff'? " + (isBoring ? "Not So!" : "All exciting stuff"));

            bool ending = name.EndsWith("h Academy");
            Console.WriteLine("Does my name end with 'h Academy'? " + (ending ? "yup" : "nope"));

            bool starting = name.StartsWith("Edge");
            Console.WriteLine("Does my name start with 'Edge'? " + (starting ? "yup" : "nope"));

            bool doTheyMatch = name.Equals("EDGE tech ACADemy");
            Console.WriteLine("Are they equal? " + (doTheyMatch ? "yup" : "nope"));

            bool ignoreCase = name.Equals("EDGE tech ACADemy", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Can I compare and ignore case? " + (ignoreCase ? "yup" : "nope"));
            int eIndex = name.IndexOf("e");
            while (eIndex >= 0)
            {
                Console.WriteLine("Found 'e' at: " + eIndex);
                eIndex = name.IndexOf("e", eIndex + 1);
            }
            string newString = name.Insert(8, ">HELLO!<");
            Console.WriteLine(newString);

            int dIndex = name.LastIndexOf('d');
            Console.WriteLine("Found last 'd' at: " + dIndex);

            string[] aNames = name.Split(" ");
            foreach (string str in aNames)
            {
                string padLeft = str.PadLeft(15, '.');
                string padRight = str.PadRight(15, '_');
                Console.WriteLine("Pad Left ->" + padLeft);
                Console.WriteLine("Pad Right ->" + padRight);

                Console.WriteLine("Unpad " + padLeft.Trim('.'));
                Console.WriteLine("Unpad " + padRight.Trim('_'));
            }

            string nickName = name.Remove(4);
            Console.WriteLine(nickName);

            Console.WriteLine("Chop characters out of the middle: " + name.Substring(7, 8));

            Console.WriteLine("Look Ma! No 'e's! " + name.Replace('e', '_'));

            Console.WriteLine("UPPER CASE: " + name.ToUpper());
            Console.WriteLine("lower case: " + name.ToLower());
        }
        enum Color { Yellow = 1, Blue, Green };
        static DateTime thisDate = DateTime.Now;

        public static void FunWithFormats()
        {
            Console.Clear();

            // Format a negative integer or floating-point number in various ways.
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                " (default):. . . . . . . . {0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                       -123, -123.45f);

            // Format the current date in various ways.
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                 "(f) Full date/short time: . . {0:f}\n" +
                 "(F) Full date/long time:. . . {0:F}\n" +
                  "(g) General date/short time:. {0:g}\n" +
                  "(G) General date/long time: . {0:G}\n" +
                  " (default):. . . . . . . . {0} (default = 'G')\n" +
                  "(M) Month:. . . . . . . . . . {0:M}\n" +
                  "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                  "(s) Sortable: . . . . . . . . {0:s}\n" +
                  "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                  "(U) Universal full date/time: {0:U}\n" +
                  "(Y) Year: . . . . . . . . . . {0:Y}\n",
                         thisDate);

            // Format a Color enumeration value in various ways.
            Console.WriteLine("Standard Enumeration Format Specifiers");
            Console.WriteLine(
                "(G) General:. . . . . . . . . {0:G}\n" +
                " (default):. . . . . . . . {0} (default = 'G')\n" +
                "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
                "(D) Decimal number: . . . . . {0:D}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                      Color.Green);
        }
    }
}
