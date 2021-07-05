using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] scores = new int[10];
            
            scores[0] = 99;
            scores[1] = 95;
            scores[2] = 90;
            scores[9] = 7;

            Console.WriteLine(scores[0]);
            Console.WriteLine(scores.Length);
            
            /*
            Console.Write("Enter the amount in the array. ");
            int length = Convert.ToInt32(Console.ReadLine());       // Combined into one line!
            int[] array = new int[length];

            //this will be a one-der-full array!
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = 1;
                Console.WriteLine(length);
            }
            */

            /*
             Indexing form the end*/

            int lastScore = scores[^1];
            Console.WriteLine(lastScore);

            // Ranges
            //int[] firstThreeScores = scores[0..1];
            //Console.WriteLine(firstThreeScores);

            //Other Ways to create Arrays

            int[] numbers = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

            Console.WriteLine(numbers[2]);

            //Arrays Example
            //Find minimum with in the array and display the minimum
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = int.MaxValue; // Start higher than anything in the array.
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentMinimum)
                {
                    currentMinimum = array[index];
                }
            }
            Console.WriteLine(currentMinimum);

            //Calculates the average value of the numbers in the array
            Console.WriteLine("Find the average of ");
            int[] arrays = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int total = 0;
            for (int index = 0; index < array.Length; index++)
            {
                total += arrays[index];
                Console.WriteLine(arrays[index]);
            }
            float average = (float)total / array.Length;
            Console.WriteLine($"The average is {average}");

            //ForEachLoop
            int[] numberss = new int[5] { 7, 10, 8, 5, 2 };
            Console.WriteLine("Items the For Each Loop will display");
            foreach (int number in numberss)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("Multi-Dimensional Arrays");

            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2 };
            matrix[1] = new int[] { 3, 4 };
            matrix[2] = new int[] { 5, 6 };

            Console.WriteLine(matrix[0][1]); // Should be 2

            Console.WriteLine();
            Console.WriteLine("Loop through all elements in a multi-dimensional array");


            int[,] matrix1 = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8, }, {9, 10, 11, 12 }, {13, 14, 15, 16 } };

            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int column = 0; column < matrix1.GetLength(1); column++)
                {
                    Console.WriteLine(matrix1[row, column] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
