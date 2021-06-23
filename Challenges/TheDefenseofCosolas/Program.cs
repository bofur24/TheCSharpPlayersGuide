using System;

namespace TheDefenseofCosolas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Ask the user for the target row and column.
                Compute the neighboring rows and columns of where to deploy the squad
                Display the deployment instructions in a different color of your choosing.
                Change the window title to be "Defense of Consolas"
                Play a sound with Console.Beep when the results have been computed and displayed
             */
            Console.Title = "Defense of Consolas";
            Console.Write("Targe Row? ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"{row}, {column - 1}");
            Console.WriteLine($"{row - 1}, {column}");
            Console.WriteLine($"{row}, {column + 1}");
            Console.WriteLine($"{row + 1}, {column}");

            Console.Beep(440, 1000);
        }
    }
}
