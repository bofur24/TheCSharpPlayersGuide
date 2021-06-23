using System;

namespace StringSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"");
            Console.WriteLine("C:\\users\\RB\\Desktop\\MyFile.txt"); // escape sequence \
            Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt"); // Verbatim string literal @

            int myFavoriteNumber = 26;            
            Console.WriteLine("My favorite number is " + myFavoriteNumber + "."); // String Concatenation
            Console.WriteLine($"My favorite number is {myFavoriteNumber}."); // String interpolation
            Console.WriteLine();

            //Alignment
            Console.WriteLine("What is your first name?");
            string name1 = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string name2 = Console.ReadLine();
            Console.WriteLine($"#1: {name1,-20}");
            Console.WriteLine($"#2: {name2,-20}");

            //formatting
            Console.WriteLine($"{Math.PI:0.000}"); // Displays 3.142
            Console.WriteLine($"{42:#.##}"); //Displays 42
            Console.WriteLine($"{42.1234:#.##}"); //Displays 42.12

            float currentHealth = 4;
            float maxHealth = 9;
            Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); //Displays 44.4%

        }
    }
}
