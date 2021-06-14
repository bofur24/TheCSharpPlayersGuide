using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;                            // Declaring a string variable
            string favoriteColor;                       // Declaring a new string variable
            int score;                                  // Declaring a int variable

            Console.WriteLine("Enter your username");
            username = Console.ReadLine();              // Assigning a value to a variable
            Console.WriteLine("Hi " + username);        // Retrieving its current value

            Console.WriteLine("Enter your new username");
            username = Console.ReadLine();              //assign new value to variable username
            Console.WriteLine("Hi " + username);        // Retrieving new variable value

            Console.WriteLine("Enter your Favorite Color");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Favorite Color is " + favoriteColor);
            
            

        }
    }
}
