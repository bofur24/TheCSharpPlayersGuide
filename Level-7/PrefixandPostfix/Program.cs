using System;

namespace PrefixandPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 5;
            int y = ++x;

            x = 5;
            int z = x++;
            Console.WriteLine("X = 5 y = ++X y now = " + y);
            Console.WriteLine("x = 5 z = X++ z now = " + z);
        }
    }
}
