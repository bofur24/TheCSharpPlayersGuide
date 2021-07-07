using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Create Method
            void CountToTen()
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(index);
                }
            }

            // Call Method
            CountToTen();
            // Call Method a second Time
            CountToTen();
            
            //Passing Parameters to the Method
            void Count(int numberToCountTo)
            {
                for (int index = 1; index < numberToCountTo; index++)
                {
                    Console.WriteLine(index);
                }

            }

            //Calling the Method with a Parameter
            Count(25);


        }

    }
}
