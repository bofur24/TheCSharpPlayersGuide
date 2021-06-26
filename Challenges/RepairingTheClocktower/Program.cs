using System;

namespace RepairingTheClocktower
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Take a number as input from the console.
                Display the word "Tick if the number is even.
                Display the word "Tock if the number is odd.
                Hint: remember that you can us the remainder operator to determine if a number is even or odd.
             */

            Console.Write("Enter a number between 1 & 12. ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int calculation = number % 2;

            if (calculation == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
            



            
        }
    }
}
