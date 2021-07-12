using System;

namespace TakingANumbrer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Make a method with the signature int AskForNumber(string text). Display the text parameter
                on the command line. Retrieve a response from the user, convert it to an int, and return it. Sample
                usage: int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
                Make a method with the signature int AskForNumber(string text, int min, int max). Only return if
                the entered number is between the min and max values. Otherwise, ask again.
                Place this method in at least one of your previous programs to impve it.
             */

            int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

            Console.Clear();

            Console.WriteLine("User 2, guess the number.");

            while (true)
            {
                int guess = AskForNumber("What is your next guess?");
                if (guess > number)
                {
                    Console.WriteLine($"{guess} is too high.");

                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low.");

                }
                else break;
            }

            Console.WriteLine("You guessed the number!");



            int AskForNumber(string text)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                return number;
            }

            int AskForNumberInRange(string text, int min, int max)
            {
               
               
                    while (true)
                    {
                        int number = AskForNumber(text);
                        if (number >= min && number <= max)
                        {
                            return number;
                        }
                    }
                
            }

        }
    }
}
