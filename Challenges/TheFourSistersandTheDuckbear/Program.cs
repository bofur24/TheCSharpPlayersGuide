using System;

namespace TheFourSistersandTheDuckbear
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Create a program that lets the user enter the number of chocolate eggs gathered that day
                Using / and % compute how many eggs each sister should get and how many are left over fo the duckbear.
             */

            Console.WriteLine("How many chocolate eggs were gathered today?");
            string chocEggsText;
            chocEggsText = Console.ReadLine();
            int chocEggs = Convert.ToInt32(chocEggsText);

            int result = chocEggs / 4;
            float remainder = chocEggs % 4;

            Console.WriteLine("Total eggs each sister gets " + result);
            Console.WriteLine("Total eggs the Duckbear gets " + remainder);
        }
    }
}
