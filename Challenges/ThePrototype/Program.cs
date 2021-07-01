using System;

namespace ThePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Build a program that will allow a user, the pilot, to enter a number.
                If the number is above 100 or less than 0, keep asking.
                Clear the screen once the program has collected a good number.
                Ask a second user, the hunter, to guess numbers.
                Indicate whether the user guessed too high, too low, or guessed right.
                Loop until thye get it right, then end the program.
             */

            Console.Write("Pilot enter a number between 0 and 100: ");
            string pilotChoice = Console.ReadLine();
            int pilot = Convert.ToInt32(pilotChoice);

            Console.Clear();

            Console.WriteLine("Hunter what is your guess>?");

            while (true)
            {
                Console.Write("What is your next guess? ");
                int hunter = Convert.ToInt32(Console.ReadLine());

                if (hunter > pilot)
                {
                    Console.WriteLine($"{hunter} is too high.");
                }
                else if (hunter < pilot)
                {
                    Console.WriteLine($"{hunter} is to low");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("You guessed the number!");
        }
    }
}
