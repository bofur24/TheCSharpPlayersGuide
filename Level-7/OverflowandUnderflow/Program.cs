using System;

namespace OverflowandUnderflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 30000;
            short b = 30000;
            short sum = (short)(a + b); // Too big to fit into a short. What happens? it overflows wrapping around back to the start -5536
            Console.WriteLine(sum);

            float c = 10000;
            float d = 0.00001f;
            float sum1 = c + d;
            Console.WriteLine(sum1); // Underflow sum1 will be 10000


            //Math and mathF Class

            // Calculate the area of a circle
            double radius = 5;

            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of the circle is " + area);

            //power and square roots
            // Pow & Sqrt

            double x = 3.0;
            double xSquared = Math.Pow(x, 2);
            double y = Math.Sqrt(xSquared);
            Console.WriteLine("Power = " + xSquared);
            Console.WriteLine("Square root = " + y);

            //Absolute value

            int xx = Math.Abs(-2);
            Console.WriteLine("-2 absolute value is " + xx);

            //Trigonometric Functions
            // Sin Cos Tan

            double y1 = Math.Sin(0);
            double y2 = Math.Cos(0);

            Console.WriteLine("Sin is " + y1);
            Console.WriteLine("Cos is " + y2);

            //Min Max and Clamp

            int smaller = Math.Min(2, 10);
            int larger = Math.Max(2, 10);

            Console.WriteLine("Smaller of 2 and 10 is " + smaller);
            Console.WriteLine("Larger of 2 and 10 is " + larger);

            int health = -1;
            health = Math.Clamp(health, 0, 100); // Keep it in the interval 0 to 100;

            Console.WriteLine("Health = " + health);

            //The MathF class
            //Same as Math just use floats instead of doubles.




        }
    }
}
