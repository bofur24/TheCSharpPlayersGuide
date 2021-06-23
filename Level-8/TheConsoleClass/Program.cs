using System;

namespace TheConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Beep(440, 1000);
            Console.Beep(550, 1000);
            Console.Title = "The Console Class";
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey(true); // overloaded 

            Console.Write("What is your name human? ");
            string userName = Console.ReadLine();

            Console.WriteLine("Your name is " + userName);
        }
    }
}
