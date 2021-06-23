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
        }
    }
}
