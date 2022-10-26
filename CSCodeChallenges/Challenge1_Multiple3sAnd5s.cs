using System.Collections.Generic;
using System;

namespace CSCodeChallenges
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Challenge One: Multiples of 3 and 5----- \n\n");

            //12. Solve the lab using the instructions below.

            //a.If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6, and 9.The sum of these multiples is 23.

            //b.Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.


            int a, b, i, Sum = 0;
            for (i = 1; i < 1000; i++)
            {
                //a = i % 3;
                //b = i % 5;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write("{0}\t", i);
                    Sum = Sum + i;
                }
            }
            Console.WriteLine("\n\n\nThe Sum of all the Multiples of 3 or 5 Below 1000 : {0}",
                              Sum);
            Console.Read();




        }//end Main()

    }//end class
}//end namespace