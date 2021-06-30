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
            

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            */
            /*
             Break out of loops and continue to the next pass
            
            Console.WriteLine("To exit the loop type exit or quit");

            while (true)
            {
                
                Console.Write("Think of anumber and type it here: ");
                string input = Console.ReadLine();

                if (input == "quit" || input == "exit")
                    break;
                
                    int number = Convert.ToInt32(input);

                    if (number == 12)
                    {
                        Console.WriteLine("I don't like that number. Pick another one.");
                        //continue;
                    }
                    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");     
            }
            */
            /*
             Nesting Loops
           

            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }

            */
            Console.WriteLine("This is a star grid based on the number of rows and columns");
            Console.Write("Enter the amount of rows.");
            string rowsInput = Console.ReadLine();
            Console.Write("Enter the amount of columns ");
            string columnsInput = Console.ReadLine();

            int rows = Convert.ToInt32(rowsInput);
            int columns = Convert.ToInt32(columnsInput);

            for (int currentRow = 1; currentRow <= rows; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < columns; currentColumn++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





        }
    }
}
