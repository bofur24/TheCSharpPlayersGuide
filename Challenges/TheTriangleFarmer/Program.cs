using System;

namespace TheTriangleFarmer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
            Area = Base X Height / 2
            Write a program that lets you input the triangle's base size and height.
            Compute the area of a triangel by turning the above equation into code.
            Write the result of the comnputation
             */

            Console.WriteLine("What is the base size");
            string baseText = Console.ReadLine();
            int baseSize = Convert.ToInt32(baseText);

            Console.WriteLine("What is the Height size");
            string heightText = Console.ReadLine();
            int heightSize = Convert.ToInt32(heightText);

            int area = (baseSize * heightSize) / 2;

            Console.WriteLine("The area of your Triangle is " + area);
        }
    }
}
