using System;

namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);

            void Countdown(int number)
            {
                if (number == 0) return;

                Console.WriteLine(number);
                Countdown(number - 1);
            }

           
        }
    }
}
