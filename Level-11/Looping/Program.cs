using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             The While Loop
            

            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine(x);
                x++;
            }

            int playersNumber = -1;

            while (playersNumber < 0 || playersNumber > 10)
            {
                Console.Write("Enter a number between 0 and 10 ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);
            }
            */
            /*
             The Do While Loop
            

            int playersNumber;

            do
            {
                Console.Write("Enter a number between 0 and 10 ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);

            } while (playersNumber < 0 || playersNumber > 10);

            Console.WriteLine($"You chose {playersNumber} it is between 0 and 10");
           */
            /*
             The For Loop
             */

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
