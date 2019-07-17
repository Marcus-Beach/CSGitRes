using System;

namespace CS_HW2_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int nSeqNum = 0, nCur1 = 1, nCur2 = 1, nTrans = 0;
            Console.WriteLine("Enter Fibonacci Sequence number.");
            while(!int.TryParse(Console.ReadLine(), out nSeqNum) || nSeqNum < 0)
            {
                Console.WriteLine("Invalid entry.  Must be a non-negative integer.");
            }

            if (nSeqNum == 0) //handle 0
            {
                Console.WriteLine("0");
                Console.ReadLine();
                return;
            }

            if (nSeqNum == 1) //handle 1
            {
                Console.WriteLine("1");
                Console.ReadLine();
                return;
            }

            if (nSeqNum == 2) //handle 2
            {
                Console.WriteLine("1");
                Console.ReadLine();
                return;
            }

            for (i = 2; i < nSeqNum; i++)
            {
                nTrans = nCur1 + nCur2;
                nCur1 = nCur2;
                nCur2 = nTrans;
            }

            Console.WriteLine("Sequence number " + nSeqNum + " is " + nTrans);

            Console.ReadLine();

        }
    }
}
