using System;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1 + 2;
            Console.WriteLine(a);

            int b = 5 - 2;
            Console.WriteLine(b);

            int c;                      // Declaring the variable c;
            c = 9 - 2;                  // Assigning a value to c, using some math;
            c = 3 + 3;                  // Another assignment.

            Console.WriteLine(c);

            int d = 3 + 1;               // Declaring d and assigning a value to d all at once
            d = 1 + 2;                   // Assigning a second value to b.

            Console.WriteLine(d);

            int e = 1;
            int f = e + 4;
            int g = e - f;

            Console.WriteLine("e = " + e + " f = " + f + " g = " + g);

            float totalPies = 4;
            float slicesPerPie = 8;
            float totalSlices = totalPies * slicesPerPie;

            Console.WriteLine("Total Slices of pie " + totalSlices);

            double moneyMadeFromGame = 100000;
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers; // We're rich!

            Console.WriteLine("Money per person is " + moneyPerPerson);

            int aa = 5;
            int bb = 2;
            int result1 = a / b;
            Console.WriteLine(result1);



        }
    }
}
