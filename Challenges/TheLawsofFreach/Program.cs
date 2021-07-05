using System;

namespace TheLawsofFreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Start with the coe for computing an array's minimum and average values
                in the section Some Examples with Arrays, starting on page 90.
                Modify the code to use foreach loops instead of for loops             
             */

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = int.MaxValue; // Start higher than anything in the array.

            foreach (int number in array)
            {
                if (number < currentMinimum)
                {
                    currentMinimum = number;
                }
                
            }

            Console.WriteLine($"The minimum number in the array is {currentMinimum}");

            int total = 0;

            foreach (int number in array)
            {
                total += number;
            }

            float average = (float)total / array.Length;
            Console.WriteLine($"The average of the array is {average:00.00}");
        }
    }
}
