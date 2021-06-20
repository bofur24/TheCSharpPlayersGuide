using System;

namespace TheDominionofKings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives
                Create a program that allows the user to enter how many provinces, duchies , and estates they have.
                Add up the uer's total score, giving 1 point per estate, 3 per duchy and 6 per province.
                Display the point total to the user.
             */

            Console.WriteLine("How many Provinces do you have?");
            string provincesText = Console.ReadLine();
            int provinces = Convert.ToInt32(provincesText);

            int provincesTotal = provinces * 6;

            Console.WriteLine("How many Duchies do you have?");
            string duchiesText = Console.ReadLine();
            int duchies = Convert.ToInt32(provincesText);

            int duchiesTotal = duchies * 3;

            Console.WriteLine("How many Estates do you have?");
            string estatesText = Console.ReadLine();
            int estates = Convert.ToInt32(provincesText);

            int estatesTotal = estates * 1;

            int kingdomTotal = estatesTotal + duchiesTotal + provincesTotal;

            Console.WriteLine("Kingdom totals");
            Console.WriteLine("Total Score for Provinces is " + provincesTotal);
            Console.WriteLine("Total Score for duchies is " + duchiesTotal);
            Console.WriteLine("Total Score for estates is " + estatesTotal);
            Console.WriteLine("Kingdom total score is " + kingdomTotal);
        }
    }
}
