using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Season current = Season.Summer;

            if (current == Season.Summer || current == Season.Winter)
            {
                Console.WriteLine("Happy Solstice!");
            }
            else
            {
                Console.WriteLine("Happ Equinox!");
            }
                        

        }
        enum Season { Winter, Spring, Summer, Fall }
    }
}
