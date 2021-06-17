using System;

namespace CompoundExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = 2 + 5 * 2;
            Console.WriteLine(result);

            int partialResult = 2 + 5;
            result = partialResult * 2;

            Console.WriteLine(result);

            result = (2 + 5) * 2;
            Console.WriteLine(result);

            result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine(result);

            double side1 = 4.5;
            double side2 = 3.5;
            double height = 1.5;

            double areaOfTrapezoid = (side1 + side2) / 2.0 * height;
            Console.WriteLine("Area of the Trapezoid is " + areaOfTrapezoid);
        }
    }
}
