using System;

namespace TheReplicatorofDTo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Make a program that creates an array of lengths 5.
                Ask the user for five numbers and put them in the array
                Make a second array of length 5.
                Use a loop to copy the values out of the original array and into the new one.
                Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again.
             */
            int[] userArray = new int[5];

            for (int item = 0; item < 5; item++)
            {
                Console.Write("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                userArray[item] = userInput;
            }

            int[] copy = new int[5];

            for (int index = 0; index < 5; index++)
            {
                copy[index] = userArray[index];
            }

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine($"{userArray[index]} and {copy[index]}");
            }

            
        }
    }
}
