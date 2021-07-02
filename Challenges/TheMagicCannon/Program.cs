using System;

namespace TheMagicCannon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Write a program that will loop though the vlaues between 1 and 100 and display what kind of blast 
                the crew should expect. (The % operator may be of use)
                Change the color of the output based on the type of blast. (For example, red for Fire, yellow for Electric, and blue for Electric and fire.)

             */

            for (int i = 0; i <= 100; i++)
                
            {
                if (i % 5 == 5 && i % 3 == 0 )
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i} Electric and Fire");                    
                }
                else if (i % 3 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i} Fire");
                }
                else if (i % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i} Electric");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i} Normal");
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
