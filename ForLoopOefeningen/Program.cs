using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average = 0;
            double numberOfElements = 10;

            Console.WriteLine("\n\n");
            Console.WriteLine("Find the sum of first 10 natural numbers: \n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("The first 10 natural numbers are: \n");
            
            for (int j = 1; j <= numberOfElements; j++) //for (int j = 1; j <= numberOfElements; j += 1) Naudy
            {
                //sum += j; Naudy
                sum = sum + j;
                Console.WriteLine("{0}", j);
 
            }
            average = sum / numberOfElements;
            Console.WriteLine("The average is: {0}\n", average);           
            Console.WriteLine("\nThe sum is: {0}\n", sum );

        }
    }
}
