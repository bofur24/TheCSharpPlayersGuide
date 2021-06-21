﻿using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            byte aByte = 3;
            int anInt = aByte;

            //explicit conversion
            int aInt = 3;
            byte aabyte = (byte)aInt;


            Console.WriteLine("anInt = " + aByte);
            Console.WriteLine("aabyte = " + aInt);


            short a = 2;
            short b = 3;

            int total = a + b; // a and b are converted to ints automatically
            Console.WriteLine(total);

            total = (short)(a + b); // keeping it casted as a short
            Console.WriteLine(total);
        }
    }
}
