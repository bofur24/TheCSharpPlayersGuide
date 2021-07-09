using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method CountToTen");
            //Create Method
            void CountToTen()
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(index);
                }
            }

            //Call Method
            CountToTen();
            Console.WriteLine();
            //Call same Method Multiple times
            CountToTen();
            Console.WriteLine("Method with parameters called Count");
            // Method with parameters

            /// <summary>
            /// Counts to the given number, starting at 1 and including the nubmer provided.
            /// </summary>
            /// <param name="numberToCountTo">The number to count to.</param>
            void Count(int numberToCount)
            {
                for (int index = 1; index <= numberToCount; index++)
                {
                    Console.WriteLine(index);
                }
            }
            // Method with a parameter
            Count(25);

            // Multiple Parameters method
            void CountBetween(int start, int end)
            {
                for (int index = start; index <= end; index++)
                {
                    Console.WriteLine(index);
                }
            }
            Console.WriteLine("Two parameters Method called CountBetween");
            //Method with 2 Parameters
            CountBetween(2, 10);

            int ReadNumber()
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                return number;
            }

            Console.WriteLine("Returning a Value From a Method");
            //Returning a value from a Method
            Console.Write("How high should I count? ");
            int number = ReadNumber();
            Count(number);


            Console.WriteLine("Returning Early");

            string GetUserName()
            {
                while (true)
                {
                    Console.Write("What is your name? ");
                    string name = Console.ReadLine();

                    if (name != "") // Empty string
                    {
                        return name;
                        Console.WriteLine("Let's try that again.");
                    }
                }
            }

            GetUserName();

            Console.WriteLine("Simple Methods with Expressions");
            int DoubleAndAddOne(int value)
            {
                return value * 2 + 1;
            }

            Console.WriteLine(DoubleAndAddOne(5));

            //Simple Method is int DoubleAndAddOne(int value) => vlaue * 2 + 1;



        }
    }
}
