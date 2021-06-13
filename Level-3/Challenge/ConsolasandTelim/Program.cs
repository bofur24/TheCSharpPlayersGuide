using System;

namespace ConsolasandTelim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Whos is the bread for?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Note: " + name + " got bread.");
        }
    }
}
