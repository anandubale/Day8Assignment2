using System;

namespace RefractoredLineProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison computational Problem On master Branch");

            LengthOfLine s1 = new LengthOfLine(5, 5, 50, 50);
            double final1 = s1.CalculateLengthOfLine();
            double lenght1 = Math.Sqrt(final1);

            LengthOfLine s2 = new LengthOfLine(10, 10, 55, 55);
            double final2 = s2.CalculateLengthOfLine();
            double lenght2 = Math.Sqrt(final2);


            Console.WriteLine("Length of line of given 4 coordinates is  " + lenght1);
            Console.WriteLine("Length of line of given 4 coordinates is  " + lenght2);

            //uc2
            if (lenght1 == lenght2) //------------------------------------->UC2
            {
                Console.WriteLine("Both Lines are Equals"); 
            }
           






        }
    }
}
