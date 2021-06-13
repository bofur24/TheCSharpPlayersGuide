using System;

namespace TheThingNamer3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");

            // Type of thing
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

            // Description
            string b = Console.ReadLine();

            // of doom text
            string c = "doom"; // removed of to fix of of bug

            /* the number */
            string d = "3000";

            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
        }
    }
}
