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
            int a;
            int b;
            int x = 0;                                  // declare a variable and initialize it on the same line
            int c, d, e;                                // declare multiple variables simultaneously if they are the same type.


            a = 5;                                      // assigning different values over time
            b = 2;

            b = a;                                      // b now is 5
            a = -3;                                     // a now is -3


            Console.WriteLine("Enter your username");
            username = Console.ReadLine();              // Assigning a value to a variable
            Console.WriteLine("Hi " + username);        // Retrieving its current value

            Console.WriteLine("Enter your new username");
            username = Console.ReadLine();              //assign new value to variable username
            Console.WriteLine("Hi " + username);        // Retrieving new variable value

            Console.WriteLine("Enter your Favorite Color");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Favorite Color is " + favoriteColor);

            Console.WriteLine("b now is " + b + " a now is " + a);
            
            
            

        }
    }
}
