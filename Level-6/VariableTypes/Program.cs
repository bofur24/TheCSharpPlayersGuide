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

            Console.WriteLine("Byte = " + aSingleByte);
            Console.WriteLine("Short = " + aNumber);
            Console.WriteLine("Long = " + aVeryBigNumber);

        }
    }
}
