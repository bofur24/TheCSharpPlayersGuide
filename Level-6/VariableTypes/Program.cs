using System;

namespace VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aSingleByte = 34;
            aSingleByte = 17;

            short aNumber = 5039;
            aNumber = -4354;

            long aVeryBigNumber = 395904282569;
            aVeryBigNumber = 13;

            ulong aVeryBigNumber1 = 10000000000u;
            int thirteen = 0b00001101;
            int theColorMagenta = 0xff00ff;
            char aLetter = '\u0061'; // 'a'
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;

            Console.WriteLine("Byte = " + aSingleByte);
            Console.WriteLine("Short = " + aNumber);
            Console.WriteLine("Long = " + aVeryBigNumber);
            Console.WriteLine("Ulong = " + aVeryBigNumber1);
            Console.WriteLine("Binary literal = " + thirteen);
            Console.WriteLine("Color Magenta = " + theColorMagenta);
            Console.WriteLine("Char letter = " + aLetter);
            Console.WriteLine("Double = " + number1);
            Console.WriteLine("Float = " + number2);
            Console.WriteLine("Decimal = " + number3);
        }
    }
}
